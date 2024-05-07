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

  ![Screenshot 2024-05-06 220913](https://github.com/Jedpyong/GrouCordApp/assets/126632651/0555178d-e43e-4244-966d-24667d428560)

### Add Member Page

- This Page just lets the leader add some more members to the group.

![Screenshot 2024-05-06 220831](https://github.com/Jedpyong/GrouCordApp/assets/126632651/615fcdc5-80a5-4bfb-9af6-4f5f812c79de)

### Profile Page
- The Profile page shows the relevant information of the user but it also serves as settings that allows the user to modify their account and password. It also supports changing profile pictures and relevant information.
- This page also contains the Logout button.

![Screenshot 2024-05-06 214925](https://github.com/Jedpyong/GrouCordApp/assets/126632651/10ab1600-4e32-4776-89ba-95fb222fa6ef)

## Use Case Diagram

![Screenshot 2024-05-03 170856](https://github.com/Jedpyong/GrouCordApp/assets/126632651/2c32d5b1-1b32-4e1b-96b0-66d88fe6c229)

- This use case diagram represent the **GrouCord**.

## Database Model
![Screenshot 2024-05-03 153718](https://github.com/Jedpyong/GrouCordApp/assets/126632651/2533e12e-8372-4864-b8e2-46413951f34f)

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
- To view for the events documentation, the PDF copy can be accessed in this [link](GrouCord-Events-Documentation.pdf).

## Presentation
- The presentation of this project can be viewed [here](https://www.canva.com/design/DAF_1gZZkSQ/s0HsceOxAE-ILXeM-Qkqbg/edit?utm_content=DAF_1gZZkSQ&utm_campaign=designshare&utm_medium=link2&utm_source=sharebutton).

## System Design
![Screenshot 2024-05-03 143941](https://github.com/Jedpyong/GrouCordApp/assets/126632651/0345f5e6-e8ff-409e-8af8-cfcc94411b76)

- These were the classes used on developing this app. I have created a class named `DBManager` and `GroupHandler` that will execute all the queries from my GUI forms, where `GroupHandler` is for queries related to a group while `DBManager` is for the rest, for an effecient and easy debugging.  




**Jade Jaballa**  
*BS in Computer Science, 2nd Year*  
Visayas State University

---
