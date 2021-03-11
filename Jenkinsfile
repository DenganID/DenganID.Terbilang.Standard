pipeline {
  agent any
  stages {
    stage('.NET') {
      parallel {
        stage('restore') {
          steps {
            sh 'dotnet restore'
          }
        }

        stage('build') {
          steps {
            sh 'dotnet build --no-restore'
          }
        }

      }
    }

  }
}