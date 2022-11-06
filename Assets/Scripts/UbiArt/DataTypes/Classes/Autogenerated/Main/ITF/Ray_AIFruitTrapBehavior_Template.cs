using UnityEngine;

namespace UbiArt.ITF {
	[Games(GameFlags.RO)]
	public partial class Ray_AIFruitTrapBehavior_Template : CSerializable {
		public float delay;
		public float weightThreshold;
		public Generic<AIAction_Template> standAction;
		public Generic<AIAction_Template> fruitFallAction;
		protected override void SerializeImpl(CSerializerObject s) {
			base.SerializeImpl(s);
			delay = s.Serialize<float>(delay, name: "delay");
			weightThreshold = s.Serialize<float>(weightThreshold, name: "weightThreshold");
			standAction = s.SerializeObject<Generic<AIAction_Template>>(standAction, name: "standAction");
			fruitFallAction = s.SerializeObject<Generic<AIAction_Template>>(fruitFallAction, name: "fruitFallAction");
		}
		public override uint? ClassCRC => 0xB4066175;
	}
}

