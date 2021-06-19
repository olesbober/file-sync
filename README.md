## File Sync App

The idea of this project is to create an application where a user can select two different folders, and File Sync will constantly keep the files between those two folders synced. Any new files added in either folder must also be added into the other folder, any file deleted must be deleted in the other folder, and any file that is updated must also be updated in the other folder. If any file has metadata associated with it, that must be synced as well (Artist, Date Downloaded, Album, etc).

The project must run in a windowed application. It should be able to start up with the system it is installed on, and there should be an installation package that any user can download (.exe, .dmg, etc). It should also include the following features:
- Remember the folders that the user wants to be synced
- Allow functionality to sync folders on external drives (for example, removable hard drives, mobile phones, etc)
- Allow more than two folders to be synced to each other
- Store previous sync information (when two folders were last synced, what changes were made, etc)
- Have a list of all folders that are synced
- A nice and big 'SYNC NOW' button

The following features are optional and can be implemented for further functionality:
- An application update functionality
- The ability to sync folders across different devices over the same WiFi network

- Random Easter eggs in the code
- Sync recovery and/or sync undo
- Report bug feature

If any other interesting ideas for features pop up during development, this README will be updated.

If the application starts to catch attention and begins to build a significant number of downloads, it might be a good idea to implement a forum somewhere where users can submit development requests. For now, this project is not planned to be open-source because it is meant to be a learning experience. All the development should be done on GitHub. Learning how to properly use commits, code reviews, issues, and pull requests is also part of this project.

Finally, there should be some basic branding as well. A better name for the application, as well as a logo and a themed GUI would be ideal.