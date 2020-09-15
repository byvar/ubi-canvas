using UnityEngine;

namespace UbiArt.ITF {
	[Games(GameFlags.COL)]
	public partial class Mission_Template : CSerializable {
		public Placeholder onAvailableActions;
		public Placeholder introSteps;
		public Placeholder bodySteps;
		public StringID cheatLocation;
		public bool sendTracking;
		public string dlcPackage;
		protected override void SerializeImpl(CSerializerObject s) {
			base.SerializeImpl(s);
			onAvailableActions = s.SerializeObject<Placeholder>(onAvailableActions, name: "onAvailableActions");
			introSteps = s.SerializeObject<Placeholder>(introSteps, name: "introSteps");
			bodySteps = s.SerializeObject<Placeholder>(bodySteps, name: "bodySteps");
			cheatLocation = s.SerializeObject<StringID>(cheatLocation, name: "cheatLocation");
			sendTracking = s.Serialize<bool>(sendTracking, name: "sendTracking", options: CSerializerObject.Options.BoolAsByte);
			dlcPackage = s.Serialize<string>(dlcPackage, name: "dlcPackage");
		}
		public override uint? ClassCRC => 0x8F80C479;
	}
}

