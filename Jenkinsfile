pipeline {
  agent any
  stages {
    stage('Deploy') {
      steps {
        sshPublisher(masterNodeName: 'Test', failOnError: true)
      }
    }

  }
}