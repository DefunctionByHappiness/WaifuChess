pipeline {
  agent any
  stages {
    stage('Deploy') {
      steps {
        sh '''sudo su jarodieg <<EOF
id -un
cd ~/WaifuChess/build/WaifuChess
git pull
cd ..
pm2 restart MurianBot
exitEOF'''
      }
    }

  }
}