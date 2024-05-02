# almanac-dotnet

docker build -t almanac-dotnet .

docker run -d --name almanac-dotnet-service almanac-dotnet

docker stop <container_id>


docker run -p 8080:8080 -p 50000:50000 -d -v jenkins_home:/var/jenkins_home jenkins/jenkins:lts
Jenkins UUID Pwd c885cb91bcdb4504931486172a0eb6b8
jenkins-user
J3nk1n5P@55w0rd