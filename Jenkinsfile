pipeline {
  agent any
  stages {
    stage('Deploy') {
      steps {
        sh '''sudo su jarodieg
id -u
cd ~/WaifuChess/build/WaifuChess
git pull
cd ..
pm2 restart MurianBot
exit'''
      }
    }

  }
}