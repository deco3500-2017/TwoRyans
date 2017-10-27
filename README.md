# Promotional Material
For the trade show our prototype itself acted as an effective means of promoting our idea, as we were the only group set up on a large multi-touch screen. Despite this, we also created a poster and a small [website](https://s4318132-deco1800.uqcloud.net/index.html) so that interested parties could explore the main functionality of the prototype without having to clone the Unity project and run it on a touch screen.

**Promotional Poster for ZORE:**
![Promo Poster for ZORE](https://user-images.githubusercontent.com/21353892/32089775-526adabc-bb2f-11e7-8cc6-4c702bc26d46.png)

# Instructions for Building the prototype
1. Clone this repository.
2. Open the prototype (found in the deco3500 prototype folder) in Unity v. 2017.1.03f or higher.
3. Go to Assets/Scenes and open StartUp.
4. Run the prototype.

Alternatively, a limitied version of the prototype (without package creation) can be accessed [here](https://s4318132-deco1800.uqcloud.net/index.html).

# Documentation of Progress
Progress was documented in [this](https://github.com/deco3500-2017/TwoRyans/wiki/Documentation-of-Progress) wiki page.

# Who did what?
**Ryan P:** was responsible for creating and testing the prototype.  
**Ryan dW:** was responsible for organising and conducting user-testing (both with teachers and students).  
**Annie:** was responsible for UX design and creation of promotional material (with the help of Ryan P for the website).  

# Table of Contents (Proposal)
- [TwoRyans](#tworyans)
- [Introduction](#introduction)
- [Concept](#concept)
  - [MVP](#mvp)
    - [Category Mode](#category-mode)
    - [Story Mode](#story-mode)
  - [Innovation](#innovation)
  - [The Audience](the-audience)
- [Team](#team)
  - [Workload Distribution and Responsibility](#workload-distribution-and-responsibility)
  - [Decision Making](#decision-making)
  - [Rule Breaches](#rule-breaches)
- [Communication](#communication)
  - [File Sharing](#file-sharing)
- [The Plan](#the-plan)
  - [Research](#research)
  - [Prototyping](#prototyping)
  - [Implementation](#implementation)
- [Tags](#tags)

# TwoRyans
This is the repository for team TwoRyans for DECO3500, 2017. It will house the code for their project, ZORE, a versatile, interactive learning tool that can be used by teachers to encourage collaborative learning in students.

# Introduction  
ZORE aims to solve two dilemmas often faced by teachers in modern day classrooms. Firstly, teachers find it difficult to get students to engaged with the content they're presenting. Interacting with presented material can often help tactile, visual or aural learners retain information better, which can be the difference between cementing and forgetting a concept.

Secondly, teachers often try to include elements of collaboration in their classroom activities. Getting students to work together and engage in collective learning can require an immense level of supervision and preparation for teachers. However, in recent times it has become more or less mandantory for teachers to include these types of activities in their lesson plans because of the huge benefits that have been found to stem from collaborative learning.

ZORE solves these dilemmas by providing an innovative, interactive learning tool for teachers that will get students collaboratively solving problems together in the classroom, while it the same time cementing their knowledge on facts from any number of academic disciplines.

# Concept
ZORE will utilise a large, multi-touch, desk-mounted interactive screen (like the one currently found in 78-207 at UQ) to create a fun, interactive classroom activity.

## MVP
ZORE has two modes to provide maximum versatility to the teacher. A categories mode, in which students are required to place a number of cards into the correct answer category and a story mode, where students assemble a story from different cards based on knowledge gained and class discussion. Both modes include progress tracking and analytics features that are saved for the teacher to review after the lesson.

### Category Mode
For preparation, the teacher will divise 2-9 broad categories with potentially overlapping attributes belonging to each category. They will then come up with any number of different cards that each belong to a specific category. Cards may contain any combination of text, images and videos.

In class, students are divided into two competing teams (one for each screen). The cards are initially jumbled between the categories on the screen. The students are required to come to a consensus about which category they believe each card belongs to and move it to the corresponsing section of the screen as seen in the diagram. When they believe every card on the screen has been categorized correctly, they press a (virtual) button to check their answers. Points are awarded based on the number of correct answers and time taken to complete the task. The team with the highest number of points wins.

![Category Diagram](http://i.imgur.com/k0QH3VH.jpg "Category Mode")

### Story Mode
Students sitting at the interactive table are presented with a scattered array of interactive/electronic cards that they can choose to flip around and manipulate (drag around the table skew, pinch-to-zoom, etc). To discuss how this will work in practice (and to provide context of use), an example will be used of historical events (‘stories’ that took place in the past), for a teacher giving a history lesson. 

Each card on the table (as shown in the diagram below) acts as a part of a story, or a ‘clue’. Once a card has been flipped over, a section of a story is revealed, for the students to act on and discuss. The goal for the students is to collaborate through their gaining of knowledge from each card, and to combine these together by dragging the relevant cards into the centre circle. The outcome of this is that the centre circle either ‘approves’ or ‘rejects’ the combination of cards (by flashing green or red respectively). If the correct combination of cards (sections of a story) have been submitted, the centre circle displays an image or video telling the full story to the students. This type of implicit learning is the result of the students having interactively and collectively discussed their individual parts, to come up with something together as a whole.

![Story Diagram](http://i.imgur.com/7fqdtgN.jpg "Story Mode")

## Innovation
One product that is similar to ZORE is [ActivTable](https://www.prometheanworld.com/au/products/interactive-table/). Designed and created by Promethean World, it uses comparable ideas to demonstrate the ways in which children learn. Accommodating for up to six students at a time, they can collaborate using educational activities, applications, and tools. The ActivTable is multi-touch, and incorporates web browsers and other resources to enhance learning experiences of children. ZORE will differ from this product by providing a considerably simpler, easier to use interface at what is guarunteed to be at a much lower final pricepoint.
![ActivTable](http://i.imgur.com/qAp6cqi.png)

Another comparable product comes from Smart Tech’s [SMART Board](https://home.smarttech.com/). This tool allows teachers to present information in a fun, interactive way that the students can enjoy. The 7000 series SMART Board incorporates pen and eraser tools to limit the adjustment for a teacher transferring from more traditional white (or black) boards. Also featuring 16 simultaneous touch points, this vertical system allows for collaboration of 4-8 students. The main issue regarding the SMART Board system is that it is oriented vertically, resulting in a potential inaccessibility for younger children, as well as a less intuitive way of processing information (as children generally work on horizontal tables).
![SMART Table](http://i.imgur.com/4NVe8VT.jpg)



## The Audience
As ZORE is a teaching tool, the primary audience will be middle school teachers. Teachers span a broad (but exclusively adult) age group, with an extremely varied level of IT familiarity and free time. Because of this, a key design goal will be that the preparation time for ZORE is no more than what is required for a normal lesson of similar complexity. The interface for creating an activity must be simple to use, with clear instructions available for the creation of multimedia answer cards. Example quizzes will be provided as standard to give teachers default configurations and entice them into using the application. The tracking features of the application will hopefully also convince teachers that ZORE is a worthwhile learning tool.

The secondary audience will be middle school students from grades 4-7. This age group was chosen because they will likely have developed enough social skills to navigate through the complex group task presented to them by ZORE, while still dealing with concepts that are simple enough to be turned into ZORE activities. It is anticipated that the simple touch interaction of the screens will be appropraite for children in this age group. Students who are visual or tactile learners will likely get the most benefit out of ZORE.


# Team

Team Member             | Student Number |    Key Roles
----------------------- | -------------- | ------------------
Ryan de Weijer          | 43210299       | UX / Front End Designer
Ryan Pousson            | 43181326       | Team Leader / App Development
Martinus Kamangudi      | 44595809       | Researcher
Annie Huang             | 43257490       | UX / Front End Programmer

The table above outlines each member and their respective key roles and contributions to the project. Ryan Pousson has been elected as the Team Leader and will manage the project and ensure timeframes and schedules are being adhered to. Each individual is responsible for their own transport and everything else pertaining to the logistics of attending meetings (both physical and virtual) - further details are noted below under **Communications**. 

## Workload Distribution and Responsibility

All members will attend the workshop on Tuesday 08:00-10:00 and arrange additional weekly team meetings on a case by case basis. All members will contribute to the project workload equally, and agree to undertake and complete project tasks assigned to them in a timely manner. 

Where members cannot complete a task in the required time, they will notify the rest of the group immediately to reallocate the task or ask for assistance.
All members agree to complete tasks to the best of their ability, and to ask for assistance when unable to do so. 


## Decision Making
With regards to decision-making and relevant policies, the team will arrange to make most major decisions during the weekly Workshops (Tuesdays 08:00-10:00), but it is crucial that each person is easily contactable via the specified Discord chat to allocate given 


## Rule Breaches
In the first instance, a meeting will be called to discuss the breach. The offending group member will have the opportunity to respond in his defence. The allegations and proposed solution will be documented and shared with all members in Google Docs.

If no action is taken on the part of the offending member to rectify the issues, a further meeting will be called and the allegations and proposed solution will be shared with all group members and a copy will be emailed to the course coordinator. Attempts will be made to contact that person via another method to address the issues.

If the offending member makes no attempt to rectify the issues following two attempts to address the issue directly, the course staff will step in to assist.


# Communication

The group agrees to use a designated Discord server (channel name: #deco3500) as the primary method of communication, as it includes both messaging, as well as group audio-calls which are easily toggled on/off within Discord. Because of its flexibility and compatibility on desktop as well as mobile, it is believed that this will facilitate communication in the clearest and most efficient way possible.

For more casual communication and scheduling meetings, the group will use Facebook Messenger, and in the rare cases of emergencies, the group agrees to call using the Facebook Messenger service.

All group members agree to respond to communications from other group members in a timely manner, and they each agree to communicate effectively and treat each other with respect, consideration and dignity. Where criticism is given, it will be given in a constructive and respectful manner. The team Github repository will be the only location for relevant code to be amalgamated, and group members will commit code to Github in a timely and appropriate manner. 

## File Sharing

All files will be shared in a designated Google Drive folder and will provide constant access for all members at any given time. File-naming conventions will follow this structure: DocumentType_OwnerInitials. Including the Team Name has been deemed unnecessary as it is contained in the Google Drive Folder itself. 

# The Plan
One of our group members (Martinus) has stated that we may be able to perform user testing on a Sunday School that he is a part of. If we are able to receive proper informed consent, this will be an extremely valuable tool for testing our application. We are also in the process of reaching out to a number of teachers to gain insight into how much preparation/training would be appropriate to implement a lesson plan with ZORE. User research will be conducted before the creation of a prototype, and user testing will be conducted on the prototype itself once it has been implemented.

## Research
1. Identify primary users
    - interview
    - focus group
2. Create user personas
3. Establish context of product usage
    - physical
    - technological
4. Establish tools required for next stage
    - programs
    - physical protoyping material

## Prototyping
1. Determine system structure
    - task flow
    - UI
    - Style guide
    - architecture
2. Prototype Development
    - digital wireframes
    - paper protoyping
    - low fidelity
3. User Testing
    - Questionnaire
    - Qualitative data

## Implementation
1. Preparation Interface
2. Application Interface
3. User testing
    - high fidelity
    - larger sample size

# Tags
#ZORE, #education, #primaryschool, #interaction, #physicaldesign, #learningtool, #activelearning, #tactile
