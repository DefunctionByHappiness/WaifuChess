pipeline {
  agent any
  stages {
    stage('Deploy Code') {
      steps {
        sh '''sudo su jarodieg <<EOF
 id -un
 cd ~/WaifuChess/build/WaifuChess
 git pull
 exit
EOF'''
      }
    }

    stage('Build Unity WebGL') {
      steps {
        sh 'echo'
      }
    }

    stage('Clean') {
      steps {
        sh 'echo'
      }
    }

  }
}