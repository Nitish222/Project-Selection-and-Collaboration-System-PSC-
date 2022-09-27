# Project-Selection-and-Collaboration-System-PSC-
I created this project in my Decision Support System Course, 

The project uses all Dotnet-based technologies, as it makes the development easier and 
faster to configure.
### Blazor - For the frontend of the application Blazor will be used, Blazor provides rich UI 
components of the dashboard for the system. Blazor runs on ASP.net that makes it easier to 
integrate, our machine learning model in the Blazor app further providing scalability and
stability. 
### Azure – Azure cloud server will be used as hosting for our SQL database, the SQL database 
provides less redundancy and for our recommendation ML models we need clean data where 
columns 
### ML.net Model Builder – ML.net Model Builder, is used to easily implement machine learning 
models into dot net applications. The ML.net framework will be used to develop the suggestionbased models for both collaboration and project suggestion in the system. To do so, the dataset 
from Kaggle and some custom-made datasets will be used to train and create the model

![image](https://user-images.githubusercontent.com/42764026/192438673-c48e37b8-3f58-46a5-845e-9fb851811ba2.png)

To understand and make our recommendation model, we need a dataset with a clear purpose, to 
achieve so, there will be three datasets that is training, testing, and final production data–
The training and testing datasets will be in form of a CSV file to just familiarize our model with 
what kind of data to expect and what kind of Machine learning algorithm works best for it, this is 
done through the model builder with help of r-square value. To assess the results from the ML 
algorithm the results with a greater than 0.4 score that is 40% will be accepted and added to the 
suggestion list 

To understand and make our recommendation model, we need a dataset with a clear purpose, to 
achieve so, there will be three datasets that is training, testing, and final production data–
The training and testing datasets will be in form of a CSV file to just familiarize our model with 
what kind of data to expect and what kind of Machine learning algorithm works best for it, this is 
done through the model builder with help of r-square value. To assess the results from the ML 
algorithm the results with a greater than 0.4 score that is 40% will be accepted and added to the 
suggestion list 

Sample Training datasets 
The system needed some dependent variables to relate the field of study with the career relevance 
and also the project timeline is crucial while suggesting a project, the timeline can decide whether 
the project will be successful or not, so all of these variables are included in our training dataset. 

The user inputted variables in this sample dataset will be a timeline, career, and Field of Study, 
these variables are inputted in our ML model for assessment.

![image](https://user-images.githubusercontent.com/42764026/192438829-76eeac45-bfeb-4b63-81e5-1097973b6693.png)

![image](https://user-images.githubusercontent.com/42764026/192438926-1e0cf62e-d272-432b-af53-27f4deeeb6c9.png)


What I learned :

- Supervised and unsupervised learning 
- ASP.net Development
- ML.net model evaluation 

MVP Video - https://www.youtube.com/watch?v=FdFSQob34BE

