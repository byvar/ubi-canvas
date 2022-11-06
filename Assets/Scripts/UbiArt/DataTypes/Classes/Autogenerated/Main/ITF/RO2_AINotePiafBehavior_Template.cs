using UnityEngine;

namespace UbiArt.ITF {
	[Games(GameFlags.RL | GameFlags.RA)]
	public partial class RO2_AINotePiafBehavior_Template : TemplateAIBehavior {
		public float weightThreshold;
		public float flyBackDelay;
		public float fallBreakDelay;
		public Vec3d appear3dOffset;
		public bool isBumper;
		public CArray<StringID> noteFxNames;
		public Generic<AIAction_Template> standAction;
		public Generic<AIAction_Template> fallResistAction;
		public Generic<AIAction_Template> catchAction;
		public Generic<AIAction_Template> fallBreakAction;
		public Generic<AIAction_Template> appear3dAction;
		public Generic<AIAction_Template> disappear3dAction;
		public Generic<AIAction_Template> flyBackAction;
		public Generic<AIAction_Template> landAction;
		public Generic<AIAction_Template> pseudoDeathAction;

		protected override void SerializeImpl(CSerializerObject s) {
			base.SerializeImpl(s);
			weightThreshold = s.Serialize<float>(weightThreshold, name: "weightThreshold");
			flyBackDelay = s.Serialize<float>(flyBackDelay, name: "flyBackDelay");
			fallBreakDelay = s.Serialize<float>(fallBreakDelay, name: "fallBreakDelay");
			appear3dOffset = s.SerializeObject<Vec3d>(appear3dOffset, name: "appear3dOffset");
			isBumper = s.Serialize<bool>(isBumper, name: "isBumper");
			noteFxNames = s.SerializeObject<CArray<StringID>>(noteFxNames, name: "noteFxNames");
			standAction = s.SerializeObject<Generic<AIAction_Template>>(standAction, name: "standAction");
			fallResistAction = s.SerializeObject<Generic<AIAction_Template>>(fallResistAction, name: "fallResistAction");
			catchAction = s.SerializeObject<Generic<AIAction_Template>>(catchAction, name: "catchAction");
			fallBreakAction = s.SerializeObject<Generic<AIAction_Template>>(fallBreakAction, name: "fallBreakAction");
			appear3dAction = s.SerializeObject<Generic<AIAction_Template>>(appear3dAction, name: "appear3dAction");
			disappear3dAction = s.SerializeObject<Generic<AIAction_Template>>(disappear3dAction, name: "disappear3dAction");
			flyBackAction = s.SerializeObject<Generic<AIAction_Template>>(flyBackAction, name: "flyBackAction");
			landAction = s.SerializeObject<Generic<AIAction_Template>>(landAction, name: "landAction");
			pseudoDeathAction = s.SerializeObject<Generic<AIAction_Template>>(pseudoDeathAction, name: "pseudoDeathAction");
		}
		public override uint? ClassCRC => 0x38D585E0;
	}
}

