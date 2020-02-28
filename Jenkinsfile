pipeline {
  agent any
  stages {
    stage('Deploy') {
      steps {
        sh '''cd /home/jarodieg/WaifuChess/build/WaifuChess
git checkout dev
git pull
cd ..
pm2 restart waifuchess
'''
      }
    }

  }
  environment {
    SSH_PASS = 'TeQuieroFab1!'
  }
}