pipeline
{
    agent any
    stages
    {
        stage('Checkout')
        {
            steps
            {
                git 'https://github.com/debeski/Day2App2.git'
                echo 'Checkout Completed'
            }
        }
        stage('Restore')
        {
            steps
            {
                bat 'dotnet restore'
                echo 'Restored All Packages Successfully'
            }
        }
        stage('Build')
        {
            steps
            {
                bat 'dotnet build'
                echo 'Build Completed Successfully'
            }
        }
        stage('Run')
        {
            steps
            {
                bat 'dotnet run'
                echo 'Completed All The Steps in the Pipeline Successfully'
            }
        }
    }
}
post
{
    success{
        echo 'Pipeline Completed successfully'
    }
    failure
    {
        echo 'Pipeline Failed'
    }
}
