namespace UbiArt.online {
	public enum SNSType {
		[Serialize("SNSType_Unknown")] SNSType_Unknown = 0,
		[Serialize("SNSType_Facebook")] SNSType_Facebook = 1,
		[Serialize("SNSType_GameCenter")] SNSType_GameCenter = 2,
		[Serialize("SNSType_GameCircle")] SNSType_GameCircle = 3,
		[Serialize("SNSType_GameServices")] SNSType_GameServices = 4,
		[Serialize("SNSType_SinaWeibo")] SNSType_SinaWeibo = 5,
		[Serialize("SNSType_Fake")] SNSType_Fake = 6,
		[Serialize("SNSType_Twitter")] SNSType_Twitter = 7,
		[Serialize("SNSType_MMS")] SNSType_MMS = 8,
	}
}
