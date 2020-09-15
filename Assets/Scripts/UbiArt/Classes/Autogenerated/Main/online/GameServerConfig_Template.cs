using UnityEngine;

namespace UbiArt.online {
	[Games(GameFlags.RA)]
	public partial class GameServerConfig_Template : ITF.TemplateObj {
		public string NodeJsUrl;
		public RequestOptions DefaultRequestOptions;
		public RequestOptions VerboseRequestOptions;
		public RequestOptions SilentRequestOptions;
		public string facebookPageURL;
		public string CommunityChannelURL;
		public uint crossPromoMaxDisplayCountTotal;
		public uint crossPromoMaxDisplayCountWeekly;
		public uint crossPromoMinAdventure;
		public uint crossPromoMinDelay;
		public bool CancelAndFailOperationsOnForeground;
		public float CheckOperationCountDelay;
		protected override void SerializeImpl(CSerializerObject s) {
			base.SerializeImpl(s);
			NodeJsUrl = s.Serialize<string>(NodeJsUrl, name: "NodeJsUrl");
			DefaultRequestOptions = s.SerializeObject<RequestOptions>(DefaultRequestOptions, name: "DefaultRequestOptions");
			VerboseRequestOptions = s.SerializeObject<RequestOptions>(VerboseRequestOptions, name: "VerboseRequestOptions");
			SilentRequestOptions = s.SerializeObject<RequestOptions>(SilentRequestOptions, name: "SilentRequestOptions");
			facebookPageURL = s.Serialize<string>(facebookPageURL, name: "facebookPageURL");
			CommunityChannelURL = s.Serialize<string>(CommunityChannelURL, name: "CommunityChannelURL");
			crossPromoMaxDisplayCountTotal = s.Serialize<uint>(crossPromoMaxDisplayCountTotal, name: "crossPromoMaxDisplayCountTotal");
			crossPromoMaxDisplayCountWeekly = s.Serialize<uint>(crossPromoMaxDisplayCountWeekly, name: "crossPromoMaxDisplayCountWeekly");
			crossPromoMinAdventure = s.Serialize<uint>(crossPromoMinAdventure, name: "crossPromoMinAdventure");
			crossPromoMinDelay = s.Serialize<uint>(crossPromoMinDelay, name: "crossPromoMinDelay");
			CancelAndFailOperationsOnForeground = s.Serialize<bool>(CancelAndFailOperationsOnForeground, name: "CancelAndFailOperationsOnForeground");
			CheckOperationCountDelay = s.Serialize<float>(CheckOperationCountDelay, name: "CheckOperationCountDelay");
		}
		public override uint? ClassCRC => 0x56AE7399;
	}
}

