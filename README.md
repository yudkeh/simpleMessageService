# simpleMessageService

Simple C# microservice which get string and return it reversed.

#How to use:

1. clone the project.
2. execute the following docker commads:
docker build -t simplemessageservice .
docker run -d -p 80:80 -name simplemessageservice_1 simplemessageservice
3. executre the follwoing REST call:
curl http://localhost/api/message/{message}
  
for example:
curl http://localhost/api/message/abcde<br>
"edcba"
