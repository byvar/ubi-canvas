using UnityEngine;

namespace UbiArt.online {
	[Games(GameFlags.RA)]
	public partial class SocialNetworkIdentity : CSerializable {
		public SNSType sns_type;
		public string sns_pid;
		public string sns_token;
		public string sns_username;
		public string sns_mail;
		public uint sns_gender;
		public uint sns_agemin;
		public uint sns_agemax;
		protected override void SerializeImpl(CSerializerObject s) {
			base.SerializeImpl(s);
			sns_type = s.Serialize<SNSType>(sns_type, name: "sns_type");
			sns_pid = s.Serialize<string>(sns_pid, name: "sns_pid");
			sns_token = s.Serialize<string>(sns_token, name: "sns_token");
			sns_username = s.Serialize<string>(sns_username, name: "sns_username");
			sns_mail = s.Serialize<string>(sns_mail, name: "sns_mail");
			sns_gender = s.Serialize<uint>(sns_gender, name: "sns_gender");
			sns_agemin = s.Serialize<uint>(sns_agemin, name: "sns_agemin");
			sns_agemax = s.Serialize<uint>(sns_agemax, name: "sns_agemax");
		}
		public enum SNSType {
			[Serialize("SNSType_Unknown"     )] Unknown = 0,
			[Serialize("SNSType_Facebook"    )] Facebook = 1,
			[Serialize("SNSType_GameCenter"  )] GameCenter = 2,
			[Serialize("SNSType_GameCircle"  )] GameCircle = 3,
			[Serialize("SNSType_GameServices")] GameServices = 4,
			[Serialize("SNSType_SinaWeibo"   )] SinaWeibo = 5,
			[Serialize("SNSType_Fake"        )] Fake = 6,
			[Serialize("SNSType_Twitter"     )] Twitter = 7,
			[Serialize("SNSType_MMS"         )] MMS = 8,
		}
	}
}

