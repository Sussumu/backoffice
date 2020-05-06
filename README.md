# backoffice


## what
A system to make it easier to execute everyday operations that consist in database queries, API calls and messaging. 


## why
From my experience, business of all sorts need to have a backoffice system to run everyday operations. 
Some of them may be temporary until another process is not automated and some may be permanent to help some internal workflow. 
Instead of developing each feature I want to create a generic interface where employees can colaborate in a more visual way, extending the creation of features to people who are not developers.

This type of system may already exists in another forms but I'd like to make it anyway in order to acquire experience.


## how
At first, the project will consist of a single repository containing the backend in .NET Core and frontend in Vue.js. 
The choice is merely based on my experience. The idea is to exercise the ports and adapters pattern for the backend. 
I don't have a great experience with Vue but anything that is componentizable is fine! This particular framework helps greatly in this aspect.


## when
Whenever it's ready! I have a problem in finishing projects so this one will be a big test!


## mvp releases
Launching in small steps is the best way to keep working. I envisioned these steps but they can change at any moment.

1. A user should be able to insert a query and call it
   This one was successfully tested on the last commit. The most basic piece of this application is proved. You can store a query and call it. 
   Now it needs a bunch of tests and validations to certify that nothing is wrong. However, it's not the time to bulletproof the feature yet. 
   Since we can't verify the user's authenticity we also can't stop him from executing a query that removes him from the database, for example.

2. API calls should join this equation

3. Messaging too

4. Login!

5. Roles need to be added to allow/deny operations

6. Webhooks are essential

7. Jobs

8. Workflows

9. Other integrations
