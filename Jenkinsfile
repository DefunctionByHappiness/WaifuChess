pipeline {
  agent any
  stages {
    stage('Deploy') {
      steps {
        sh '''cd /home/jarodieg/WaifuChess/build/WaifuChess
git pull
cd ..
pm2 restart waifuchess
'''
      }
    }

  }
}