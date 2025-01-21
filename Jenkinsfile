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
        stage('Test')
        {
            steps{
                script{
                    bat 'dotnet test --no-build --verbosity normal'
                    echo 'Tested Successfully'

                }
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
        stage('Publish')
        {
            steps
            {
                script{
                    bat 'dotnet publish --configuration Release --output ./publish'
                    echo 'Published Successfully'
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
}