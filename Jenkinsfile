pipeline {
  agent any
  stages {
    stage('Deploy') {
      steps {
        sshPublisher()
        sh 'npm install'
      }
    }

  }
}