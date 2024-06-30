# PREFINAL_ASSIGNMENT1_ANCHETA_ASHLEYSOPHIA_BSIT32E2

Self-Assessment: Onion Architecture, MVC, and Web API (.NET Core) with Bottlenecks (Encountered) Conceptual Understanding:

Onion Architecture: (Yes/No) Have you heard of the Onion Architecture principle in software design? ANSWER: Yes MVC Pattern: (Yes/No) Are you familiar with the Model-View-Controller (MVC) pattern for building web applications? ANSWER: Yes Web API: (Yes/No) Do you understand the concept of building RESTful APIs using ASP.NET Core Web API? ANSWER: No

Application & Bottlenecks: Onion Architecture:

Benefits: (1-3 keywords) Briefly list some key benefits of using Onion Architecture in .NET Core projects. (e.g., separation of concerns, testability) 
ANSWER: 
The codebase is divided into distinct layers, clearly defining the role of each part of the application. This organization aids in making changes by allowing you to locate and update the appropriate section of code without disrupting the rest.

Bottlenecks (Encountered): (Yes/No and Briefly Explain) Have you encountered any challenges with Onion Architecture in your projects? If so, briefly describe the bottleneck(s). (e.g., Increased complexity for simple projects, difficulty finding developers familiar with the pattern) 
ANSWER: 
Yes, I often find Onion Architecture difficult to grasp. I frequently run into errors and struggle to understand how this architectural style operates.

MVC: Components: (1-3 keywords each)

Briefly describe the roles of the Model, View, and Controller in the MVC pattern. 
ANSWER: 
Model - Manages data and business logic, processing data and applying rules. 
View - Presents data to the user, forming the user interface. 
Controller - Serves as an intermediary between Model and View, managing user input and updating the Model.

Bottlenecks (Encountered): (Yes/No and Briefly Explain) Have you encountered any challenges with tight coupling between Model and Controller in MVC projects? If so, briefly describe the issue(s). (e.g., Difficulty in unit testing controllers, logic changes rippling through the application) 
ANSWER: 
Yes, it can be complicated at times, but I understand the basics.

Web API: Differences from MVC: (Yes/No and Briefly Explain) Can you differentiate between traditional MVC applications and Web APIs? Briefly explain the main difference.
ANSWER: 
Traditional MVC applications are built to create complete web applications using the Model-View-Controller pattern. They involve Models for managing data and business logic, Views for rendering HTML pages, and Controllers for handling user input and interactions. These applications primarily generate dynamic web pages that users interact with through a browser.
Conversely, Web APIs aim to provide data services rather than full web applications. They use Models to manage data and Controllers to handle requests, but they do not include Views. Instead of generating HTML, Web APIs return data in formats like JSON or XML. These APIs are intended to be used by other applications or services, offering programmatic access to data and functionality without a user interface.

Bottlenecks (Encountered): (Yes/No and Briefly Explain) Have you encountered any performance challenges with traditional MVC applications compared to Web APIs? If so, briefly describe the scenario(s). (e.g., Frequent page refreshes causing performance overhead, complex data exchange requiring a more lightweight approach) 
ANSWER: 
Yes, in my experience, traditional MVC applications are more complex than Web APIs. For instance, numerous changes are often required to run or fix errors in traditional MVC applications, making them more cumbersome compared to the relatively straightforward nature of Web APIs.
