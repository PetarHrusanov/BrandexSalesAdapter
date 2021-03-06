pipeline {
  agent any
  stages {
    stage('Pull Changes') {
      steps {
        sh("#!/bin/bash git pull")
      }
    }
    // stage('Run Unit Tests') {
    //   steps {
    //     powershell(script: """ 
    //       cd Server
    //       dotnet test
    //       cd ..
    //     """)
    //   }
    // }
    stage('Docker Build') {
      steps {
        sh('#!/bin/bash /docker-compose build')
        sh('#!/bin/bash docker images -a')
      }
    }
    stage('Run Test Application') {
      steps {
        sh('#!/bin/bash /docker-compose up -d')
      }
    }

    stage('Run Integration Tests') {
      steps {
        sh('#!/bin/bash ./Tests/ContainerTests.ps1')
        // powershell(script: './Tests/ContainerTests.ps1') 
      }
    }

    stage('Stop Test Application') {
      steps {
        sh('#!/bin/bash /docker-compose down')
        
        // powershell(script: 'docker volumes prune -f')   		
      }
      post {
	    success {
	      echo "Build successfull! You should deploy! :)"
	    }
	    failure {
	      echo "Build failed! You should receive an e-mail! :("
	    }
      }
    }

    // stage('Push Images') {
    //   steps {
    //     script {
    //       docker.withRegistry('https://index.docker.io/v1/', 'DockerHub') {
    //         def image = docker.image("petarhrusanov/brandexautomationtest")
    //         image.push("1.0.${env.BUILD_ID}")
    //         image.push('latest')
    //       }
    //     }
    //   }
    // } 

    stage('Deploy Development') {
      // when { branch 'main' }
      steps {
        withKubeConfig([credentialsId: 'c8056e3e-0b35-4e8b-be5b-1a5224f1a9d5', serverUrl: 'http://35.187.82.181']) {
           sh('#!/bin/bash kubectl apply -f ./.k8s/.environment/development.yml')
           sh('#!/bin/bash kubectl apply -f ./.k8s/databases')
           sh('#!/bin/bash kubectl apply -f ./.k8s/clients')

          //  powershell(script: 'kubectl set image deployments/user-client user-client=ivaylokenov/carrentalsystem-user-client-development:latest')
        }
      }
    }
  }
}