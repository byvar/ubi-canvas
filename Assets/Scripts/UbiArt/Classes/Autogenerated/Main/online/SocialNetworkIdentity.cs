using UnityEngine;

namespace UbiArt.online {
	[Games(GameFlags.RA)]
	public partial class SocialNetworkIdentity : CSerializable {
		[Serialize("sns_type"    )] public SNSType sns_type;
		[Serialize("sns_pid"     )] public string sns_pid;
		[Serialize("sns_token"   )] public string sns_token;
		[Serialize("sns_username")] public string sns_username;
		[Serialize("sns_mail"    )] public string sns_mail;
		[Serialize("sns_gender"  )] public uint sns_gender;
		[Serialize("sns_agemin"  )] public uint sns_agemin;
		[Serialize("sns_agemax"  )] public uint sns_agemax;
		protected override void SerializeImpl(CSerializerObject s) {
			base.SerializeImpl(s);
			SerializeField(s, nameof(sns_type));
			SerializeField(s, nameof(sns_pid));
			SerializeField(s, nameof(sns_token));
			SerializeField(s, nameof(sns_username));
			SerializeField(s, nameof(sns_mail));
			SerializeField(s, nameof(sns_gender));
			SerializeField(s, nameof(sns_agemin));
			SerializeField(s, nameof(sns_agemax));
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

