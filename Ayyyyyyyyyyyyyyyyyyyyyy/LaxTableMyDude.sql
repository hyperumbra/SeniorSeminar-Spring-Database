CREATE table "GameEventsShell"(
	team varchar(255),
	actingTeamMemberNumber int,
	assistingTeamMemberNumber int,
	eventType varchar(255),
	homeScore int,
	visitorScore int,
	penaltyType varchar(255),
	eventTime DateTime,
	PRIMARY KEY (eventTime)
);

CREATE table "Games"(
	homeTeam varchar(255),
	visitingTeam varchar(255),
	datePlayed DateTime,
	gameCode guid,
	PRIMARY KEY (gameCode)
);

GO