﻿﻿// This file was auto-generated by ML.NET Model Builder. 
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Microsoft.ML.Data;
using Microsoft.ML.Trainers;
using Microsoft.ML;

namespace PSC_System
{
    public partial class MLModel
    {
        public static ITransformer RetrainPipeline(MLContext context, IDataView trainData)
        {
            var pipeline = BuildPipeline(context);
            var model = pipeline.Fit(trainData);

            return model;
        }

        /// <summary>
        /// build the pipeline that is used from model builder. Use this function to retrain model.
        /// </summary>
        /// <param name="mlContext"></param>
        /// <returns></returns>
        public static IEstimator<ITransformer> BuildPipeline(MLContext mlContext)
        {
            // Data process configuration with pipeline data transformations
            var pipeline = mlContext.Transforms.Text.FeaturizeText(@"Career_tf", @"Career")      
                                    .Append(mlContext.Transforms.Conversion.MapValueToKey(@"Project ID", @"Project ID"))      
                                    .Append(mlContext.Transforms.Conversion.MapValueToKey(@"Field", @"Field"))      
                                    .Append(mlContext.Recommendation().Trainers.MatrixFactorization(approximationRank:8,numberOfIterations:10,learningRate:0.1F,labelColumnName:@"Project Relevance",matrixColumnIndexColumnName:@"Field",matrixRowIndexColumnName:@"Project ID"));

            return pipeline;
        }
    }
}