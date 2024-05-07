# GrouCord (Group Coordinator App)

- **GrouCord** is an application developed to enhance planning, management, and coordination within a group, facilitating the creation of group projects and streamlining other collaborative activities.
- This app offers a **straightforward** and **intuitive** approach, simplifying group creation, communication, and collaboration. 
- This app allows users to focus on their group work by **minimizing distractions**, such as **irrelevant chats** and other non-essential communications that can lead to confusion and forgetfulness.
- This app was made for anyone making a team, either in school, public service, or business.
- This app is especially helpful for team leaders, empowering them to plan the team's actions effectively. It addresses a common problem faced by leaders: scheduling appointments where only a few team members attend.
- This is also gives convenience to the members as they can share and let the team know when and why they're busy so that the team can plan or talk it out ahead of time.


## Features of the System

### Login Page
This page manages the *login feature* of the system. It serves as the initial interface upon opening the application. Here you can also find the create account and forgot password features.

- Login.
  
![Screenshot 2024-05-06 210744](https://github.com/Jedpyong/GrouCordApp/assets/126632651/83aef3e5-4d7a-4391-8a3d-e2274456224d)

- Forgot Password.
  
![Screenshot 2024-05-06 210813](https://github.com/Jedpyong/GrouCordApp/assets/126632651/dc015e36-f64c-45af-ba47-f42101dd4d8a) ![Screenshot 2024-05-07 091837](https://github.com/Jedpyong/GrouCordApp/assets/126632651/b75430c7-82d7-4ed2-acd3-958a9975f548)

- Create Account.
  
![Screenshot 2024-05-06 210836](https://github.com/Jedpyong/GrouCordApp/assets/126632651/195125df-d194-4af4-af78-157e3ca315e4)


### Home Page
This page shows all the groups a user is involved in and also the status of the user which will be reflected on all of his/her group.

- Initial Home Page (without groups).

![Screenshot 2024-05-06 210930](https://github.com/Jedpyong/GrouCordApp/assets/126632651/fd04e3c4-a6ba-4032-9fcc-c4ab082c6aaa)

- Home Page (with groups).

![Screenshot 2024-05-06 213113](https://github.com/Jedpyong/GrouCordApp/assets/126632651/a12ada42-33ad-4127-9571-dfc345625d95)


### Create Group Page
This Page will be the first thing to do for a user if he/she was not added in a group. It lets the user create his/her own group with group picture, group name and initial members.

![Screenshot 2024-05-06 210956](https://github.com/Jedpyong/GrouCordApp/assets/126632651/a4eeefd4-fd15-478d-90ab-eb23645a9b58)


### Group Page
This page displays all the members of the group and also the leader of the group if the user is not the leader. This also shows the **four** buttons for navigation (Tasks, Schedules,Announcements and Add member) if the user is the leader of the team while only **two** (Tasks and Schedules) if not.

Here you can also see the bell icon where the announcements of the leader will be reflected.
- (Leader's POV).

![Screenshot 2024-05-06 214956](https://github.com/Jedpyong/GrouCordApp/assets/126632651/320c8229-7ad5-4521-8300-46277328d4ba)

- (Member's POV).

![Screenshot 2024-05-06 215604](https://github.com/Jedpyong/GrouCordApp/assets/126632651/e4935447-c2ad-47e1-a2a5-ca44c9a32182)

### Tasks Page
- In leader's POV, this page shows all tasks made within the group, assigned member(s) on a certain task and the progress of each task.

![Screenshot 2024-05-06 215501](https://github.com/Jedpyong/GrouCordApp/assets/126632651/39894b16-5b17-463b-b244-6559ee72250c)

- In member's POV, this also shows all tasks but only those assign to the member.

![Screenshot 2024-05-06 221636](https://github.com/Jedpyong/GrouCordApp/assets/126632651/3c0a612e-0185-48ee-9896-9f92474875f7)

### Schedules Page

- Schedules page just focuses on the busy schedules of each members of the group and all those schedules will be reflected to this page in the leader's POV.

![Screenshot 2024-05-06 220929](https://github.com/Jedpyong/GrouCordApp/assets/126632651/0dfe9332-2550-4303-a129-d4b603ee11af)

- In each member's POV, this page only shows all of their own busy schedules which are all provided by themselves through the 'Add Busy Sched' button on this page which is only for the members.

![Screenshot 2024-05-06 221822](https://github.com/Jedpyong/GrouCordApp/assets/126632651/b88fa203-534d-42cd-9fa9-4b2292318239)

### Announcement Page

This Page just lets the leader write and post an announcement to the group that will be reflected on the bell icon on the opper-right corner.

  
### Add Member Page

- This Page just lets the leader add some more members to the group.

![Screenshot 2024-05-06 220831](https://github.com/Jedpyong/GrouCordApp/assets/126632651/615fcdc5-80a5-4bfb-9af6-4f5f812c79de)

### Profile Page
- The Profile page shows the relevant information of the user but it also serves as settings that allows the user to modify their account and password. It also supports changing profile pictures and relevant information.
- This page also contains the Logout button.

  ![Uploading Screenshot 2024-05-06 214925.png…]()

## Use Case Diagram
![Use Case Diagram](Resources/usecase1.png "Use Case Diagram")
![Use Case Diagram](Resources/usecase2.png "Use Case Diagram")
- This use case diagram represent the **GrouCord**.

## Database Model
![ERD Model](Resources/erd_final_1.png "ERD Model")
- This ERD presents a model for **GrouCord** which I used to offer a comprehensive view of its entities and relationships. Below is a breakdown of the entities and their attributes:

### Entities:

#### Account:
- Represents individuals or user interacting with the system.
- Attributes include `accountId` (primary key), `email`, `password`, `username`, `contactNumber`, `status`, and `accountProfile`.

#### Group:
- Represents each group.
- Attributes consist of `groupID` (primary key), `groupName`, `groupLeader`, and `groupImage`.

#### GroupMember:
- Represents members within a group.
- Attributes include `groupMemberID` (primary key), `groupMemberEmail`,  and `groupID` which is a foreign key referencing Group's groupID.

#### Task:
- This represent and holds each task made within a group.
- Attributes comprise `taskID` (primary key), `description`, `taskName`, `dueDate`, `Remarks`, `link`, and `groupMemberID` which is a foreign key referencing GroupMember's groupMemberID.

#### SubmittedTask:
- this holds submitted tasks in response to the tasks assigned to a member.
- Attributes include `submittedTaskID` (primary key), `fileLink`, `description`, `dateSubmitted`, and `taskID` which is a foreign key referencing Task's taskID.

#### BusySched:
- Accumulates all of the busy schedules provided by the members of the group.
- Attributes consist of `busySchedID` (primary key), `date`, `description`, and `groupMemberID` which is a foreign key referencing GroupMember's groupMemberID.

#### Announcement:
- stores the announcements created by the leader.
- Attributes include `announcementID` (primary key), `announcementHead`, `announcementBody`, `isLatest`, `datePosted`, and `AGroupID` which is a foreign key referencing Group's groupID.

#### Status:
- stores the corresponding status image to a user's current status for display.
- Attributes comprise `statusID` (primary key), `state` and `statPic`. 


### Relationships:

- An *Account* can have one to many Groups.
- A *Group* can only be led by one *Account*.
- A *Group* can have one to many *GroupMembers*, Yet a *GroupMember* can only have one *Group*.
- A *GroupMember* can only have one *Account*.
- A *GroupMember* can have one to many *BusySched* and one to many *Task*.
- A *Group* can have one to many *Announcement* but an *Announcement* is only for one group. 


## Events Documentation
![Events Documentation](Resources/events_doc.png "Events Documentation")
- This the first page of the events documentation embedded on this repository. To view the complete copy of the documentation, the PDF copy can be accessed in this [link](Resources/Documentation-of-Events.pdf).

## Presentation
![Presentation](Resources/Presentation.png)
- The presentation of this project can be viewed [here](https://www.canva.com/design/DAF_1gZZkSQ/s0HsceOxAE-ILXeM-Qkqbg/edit?utm_content=DAF_1gZZkSQ&utm_campaign=designshare&utm_medium=link2&utm_source=sharebutton).

## System Design
![System Design](Resources/SystemDesign.png "System Design")
- These were the classes used on developing this app. I have created a class named `DBManager` and `GroupHandler` that will execute all the queries from my GUI forms, where `GroupHandler` is for queries related to a group while `DBManager` is for the rest, for an effecient and easy debugging.  

## How to Use the App?

### Prerequisite

#### MySql Server
![MySql Server](Resources/MySql_Download.png "MySql Server")
- You should have a **MySql community server**. If you don't have it, you can download it from the [official website](https://dev.mysql.com/downloads/mysql/). Follow the setup process and install it.

#### Download Resources
![Release Download](Resources/Reslease_Download.png "Release Download")
- Visit [this link](https://github.com/VSUrhuel/Mabolo-Dormitory-System/releases) to download the latest release version of this app. Click the **latest** `.msi` file to download it. 

![Database Download](Resources/Database_Download.png "Database Download")
- Navigate to the `Resources` folder in this repository and download the SQL file `SystemDatabase`.

### Set Up MySql
![SQL](Resources/sql2.png "SQL")
- Open the MySql Workbench application. Click the plus icon next to the application's text logo.

![SQL](Resources/sql1.png "SQL")
- Enter the connection name and note the `hostname` and `username`.

![SQL](Resources/sql3.png "SQL")
- Click the database you created. Go to the `server` section, click `Data Import`, select `Import from Self-Contained file`, then choose the directory where the downloaded `SystemDatabase` is located. Finally, click `Start Import`.

- Congratulations! You have finished setting up MySql! Scroll down for more!

### Set Up Environment Variables
![Environment Variables](Resources/EnvironmentVariables.png "Environment Variables")
- In Windows search, look for `environment variables` settings. In `system variables`, click `add`.

- Add these three `variable names` individually: `MYSQL_PASSWORD`, `MYSQL_SERVER`, `MYSQL_USERNAME` (follow these names strictly), and set their values to the corresponding values you entered when setting up your database.

![Information](Resources/Info.png "Information")
- If you forgot your server and username, you can view them by opening your database in workbench, clicking `server`, and going to `Manage Access Settings` > `Connection`.

- The variable value for `MYSQL_PASSWORD` is the password you entered when you first used MySql. You can view or change it by opening your database in workbench and navigating to `server` > `User and Privileges`.

### Install
- Run the installation process downloaded from [this GitHub link](https://github.com/VSUrhuel/Mabolo-Dormitory-System/releases/tag/System). **You can now use the app!**

## How to Open Using Visual Studio?
![VS](Resources/vs.png "VS")
- Click `code` at the top and select `Open with Visual Studio`.

- To fully utilize this, download various NutGet extensions, including but not limited to `MySql`, `Xunit`, and `MySql Connector`. These can be easily downloaded in NutGet Packages.

- For `GunaUI`, **DO NOT** download it from NutGet package. Manually download the `dll` file and add it to the project's references. You can download the `GunaUI.dll` from this repository.

## License Information

This project is licensed under the [MIT License](LICENSE), which means you are free to use, modify, and distribute the code as long as you include the original copyright notice and disclaimer. See the [LICENSE](LICENSE) file for more details.

## Contributing

Thank you for considering contributing to this project! Your contributions are greatly appreciated. Here are some ways you can contribute:

1. **Report Bugs**: If you encounter any bugs or issues, please [open an issue](https://github.com/yourusername/yourproject/issues) on GitHub.

2. **Suggest Features**: Have an idea for a new feature? [Open an issue](https://github.com/yourusername/yourproject/issues) and share your thoughts.

3. **Submit Pull Requests**: Fork the repository, make your changes, and submit a pull request for review.

4. **Provide Feedback**: Share your thoughts and suggestions in the project's [issues section](https://github.com/yourusername/yourproject/issues).

5. **Spread the Word**: Help others discover this project by sharing it on social media or with your peers.

Thank you for your interest and support! 🚀

## Demo


https://github.com/VSUrhuel/Mabolo-Dormitory-System/assets/114915612/cd5246cb-fec2-463d-8106-1e34f6c0089d

Here is the demo on how the application funcions. Additionally, screenshots showcasing the user interface and functionality are available in the [Screenshots](InterfaceDesigns) directory.

## Contact Information

For any questions, feedback, or support inquiries, feel free to contact me at:

- [![Facebook](https://img.shields.io/badge/Facebook-1877F2?style=flat-square&logo=facebook&logoColor=white)](https://www.facebook.com/johnrhuel.laurente)
- [![Instagram](https://img.shields.io/badge/Instagram-E4405F?style=flat-square&logo=instagram&logoColor=white)](https://www.instagram.com/rhuelski29/)
- [![LinkedIn](https://img.shields.io/badge/LinkedIn-0077B5?style=flat-square&logo=linkedin&logoColor=white)](https://www.linkedin.com/in/john-rhuel-laurente-181357248/)

## Acknowledgements

I would like to acknowledge the following individuals for their contributions to this project:

- Sir [Jomari Barera](https://github.com/infinityweaver) and Ma'am Jonah Maaghop for their guidance and tips to become this project sucessfull.

## Developer Credits

This project is developed and maintained by:

**John Rhuel Laurente**  
*BS in Computer Science, 2nd Year*  
Visayas State University

---
