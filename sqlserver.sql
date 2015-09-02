USE [CrowdSourcing]
GO
/****** Object:  Table [dbo].[solveVoteResult]    Script Date: 09/02/2015 13:42:46 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[solveVoteResult](
	[id] [int] IDENTITY(1,1) NOT NULL,
	[solveVoteWorkflowId] [nvarchar](50) NULL,
	[supportWorkflowId] [nvarchar](50) NULL,
PRIMARY KEY CLUSTERED 
(
	[id] ASC
)WITH (PAD_INDEX  = OFF, STATISTICS_NORECOMPUTE  = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS  = ON, ALLOW_PAGE_LOCKS  = ON) ON [PRIMARY]
) ON [PRIMARY]
GO
/****** Object:  Table [dbo].[solveResult]    Script Date: 09/02/2015 13:42:46 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[solveResult](
	[id] [int] IDENTITY(1,1) NOT NULL,
	[taskName] [nvarchar](50) NULL,
	[taskDescription] [nvarchar](256) NULL,
	[workflow_id] [nvarchar](50) NULL,
	[parent_workflow_id] [nvarchar](50) NULL,
	[solutions] [nvarchar](256) NULL,
	[mainTaskId] [nvarchar](50) NULL,
	[bestAnswer] [nvarchar](50) NULL,
PRIMARY KEY CLUSTERED 
(
	[id] ASC
)WITH (PAD_INDEX  = OFF, STATISTICS_NORECOMPUTE  = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS  = ON, ALLOW_PAGE_LOCKS  = ON) ON [PRIMARY]
) ON [PRIMARY]
GO
/****** Object:  Table [dbo].[decomposeVoteResult]    Script Date: 09/02/2015 13:42:46 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[decomposeVoteResult](
	[id] [int] IDENTITY(1,1) NOT NULL,
	[decomposeVoteWorkflowId] [nvarchar](50) NULL,
	[supportWorkflowId] [nvarchar](50) NULL,
	[parent_workflow__id] [nvarchar](50) NULL,
PRIMARY KEY CLUSTERED 
(
	[id] ASC
)WITH (PAD_INDEX  = OFF, STATISTICS_NORECOMPUTE  = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS  = ON, ALLOW_PAGE_LOCKS  = ON) ON [PRIMARY]
) ON [PRIMARY]
GO
/****** Object:  Table [dbo].[decomposeTree]    Script Date: 09/02/2015 13:42:46 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[decomposeTree](
	[id] [int] IDENTITY(1,1) NOT NULL,
	[taskName] [nvarchar](50) NULL,
	[taskDescription] [nvarchar](256) NULL,
	[taskOrder] [nvarchar](50) NULL,
	[taskSolution] [nvarchar](256) NULL,
	[parentId] [nvarchar](50) NULL,
	[mainTaskWorkflowId] [nvarchar](50) NULL,
PRIMARY KEY CLUSTERED 
(
	[id] ASC
)WITH (PAD_INDEX  = OFF, STATISTICS_NORECOMPUTE  = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS  = ON, ALLOW_PAGE_LOCKS  = ON) ON [PRIMARY]
) ON [PRIMARY]
GO
/****** Object:  Table [dbo].[decomposeResult]    Script Date: 09/02/2015 13:42:46 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[decomposeResult](
	[id] [int] IDENTITY(1,1) NOT NULL,
	[taskName] [nvarchar](50) NULL,
	[taskDescription] [nvarchar](256) NULL,
	[taskOrder] [nvarchar](50) NULL,
	[workflow_id] [nvarchar](50) NULL,
	[parent_workflow_id] [nvarchar](50) NULL,
	[vote] [nvarchar](50) NULL,
	[simples] [nvarchar](50) NULL,
	[mainTaskId] [nvarchar](50) NULL,
PRIMARY KEY CLUSTERED 
(
	[id] ASC
)WITH (PAD_INDEX  = OFF, STATISTICS_NORECOMPUTE  = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS  = ON, ALLOW_PAGE_LOCKS  = ON) ON [PRIMARY]
) ON [PRIMARY]
GO
/****** Object:  Table [dbo].[crowdTask]    Script Date: 09/02/2015 13:42:46 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[crowdTask](
	[id] [int] IDENTITY(1,1) NOT NULL,
	[taskName] [nvarchar](50) NULL,
	[taskDescription] [nvarchar](256) NULL,
	[taskType] [nvarchar](50) NULL,
	[workflow_id] [nvarchar](50) NULL,
	[parent_workflow_id] [nvarchar](50) NULL,
	[mainTaskId] [nvarchar](50) NULL,
PRIMARY KEY CLUSTERED 
(
	[id] ASC
)WITH (PAD_INDEX  = OFF, STATISTICS_NORECOMPUTE  = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS  = ON, ALLOW_PAGE_LOCKS  = ON) ON [PRIMARY]
) ON [PRIMARY]
GO
