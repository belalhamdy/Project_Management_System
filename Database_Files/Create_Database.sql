CREATE DATABASE ProjectManager_DB
CREATE TABLE [project_Plan] (
  [projectId] int PRIMARY KEY IDENTITY(1, 1),
  [weekStartDay] int NOT NULL,
  [workingHours] int,
  [projectName] nvarchar(255) NOT NULL,
  [startDate] datetime DEFAULT (GETDATE()),
  [dueDate] datetime DEFAULT (GETDATE())
)
GO

CREATE TABLE [deliverable] (
  [deliverableId] int PRIMARY KEY IDENTITY(1, 1),
  [projectId] int NOT NULL,
  [isFinished] BIT DEFAULT 0,
  [title] varchar(30) NOT NULL,
  [description] nvarchar(255)
)
GO

CREATE TABLE [employee] (
  [memberId] int PRIMARY KEY IDENTITY(1, 1),
  [taskId] int,
  [name] nvarchar(255) NOT NULL,
  [title] varchar(30) NOT NULL,
  [workingHours] int NOT NULL,
  [cost] int NOT NULL
)
GO

CREATE TABLE [task] (
  [taskId] int PRIMARY KEY IDENTITY(1, 1),
  [parentTask] int,
  [taskType] int NOT NULL,
  [projectId] int NOT NULL,
  [startDate] datetime DEFAULT (GETDATE()),
  [dueDate] datetime DEFAULT (GETDATE()),
  [title] varchar(30) NOT NULL,
  [actualWorkingDays] int,
  [isFinished] BIT DEFAULT 0
)
GO

ALTER TABLE [deliverable] ADD FOREIGN KEY ([projectId]) REFERENCES [project_Plan] ([projectId])ON DELETE CASCADE  on update cascade
GO

ALTER TABLE [task] ADD FOREIGN KEY ([projectId]) REFERENCES [project_Plan] ([projectId]) ON DELETE CASCADE  on update cascade
GO

ALTER TABLE [employee] ADD FOREIGN KEY ([taskId]) REFERENCES [task] ([taskId]) ON DELETE SET NULL
GO

ALTER TABLE [task] ADD FOREIGN KEY ([parentTask]) REFERENCES [task] ([taskId])
GO
