namespace UbiArt.online {
	public partial class Error : CSerializable {
		public enum GameServerError {
			[Serialize("online::Error::GS_NoError"            )] GS_NoError = 0,
			[Serialize("online::Error::GS_NeedUpdate"         )] GS_NeedUpdate = 1,
			[Serialize("online::Error::GS_ServerError"        )] GS_ServerError = 2,
			[Serialize("online::Error::GS_SessionDisconnected")] GS_SessionDisconnected = 3,
			[Serialize("online::Error::GS_SaveConflict"       )] GS_SaveConflict = 4,
			[Serialize("online::Error::GS_AuthenticationError")] GS_AuthenticationError = 5,
			[Serialize("online::Error::GS_NoNetwork"          )] GS_NoNetwork = 6,
			[Serialize("online::Error::GS_BadRequest"         )] GS_BadRequest = 7,
			[Serialize("online::Error::GS_OtherError"         )] GS_OtherError = 8,
		}
	}
}

