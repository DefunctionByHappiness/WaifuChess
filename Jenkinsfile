pipeline {
  agent any
  stages {
    stage('Deploy') {
      steps {
        sh '''ssh jarodieg@jarodieg.top -p ${SSH_PASS} <<EOF
 cd ~/WaifuChess/build/WaifuChess
 git checkout dev
 git pull
 cd ..
 pm2 restart waifuchess
 exit
EOF'''
      }
    }

  }
  environment {
    SSH_PASS = 'TeQuieroFab1!'
  }
}