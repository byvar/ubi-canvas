using UnityEngine;

namespace UbiArt.ITF {
	[Games(GameFlags.LegendsAndUp)]
	public partial class TweenFX_Template : TweenInstruction_Template {
		public StringID fx;
		public bool stop;
		public bool useLocalInitialPos;
		protected override void SerializeImpl(CSerializerObject s) {
			base.SerializeImpl(s);
			if (Settings.s.game == Settings.Game.RL) {
				fx = s.SerializeObject<StringID>(fx, name: "fx");
				stop = s.Serialize<bool>(stop, name: "stop", options: CSerializerObject.Options.BoolAsByte);
			} else if (Settings.s.game == Settings.Game.COL) {
				fx = s.SerializeObject<StringID>(fx, name: "fx");
				stop = s.Serialize<bool>(stop, name: "stop", options: CSerializerObject.Options.BoolAsByte);
				useLocalInitialPos = s.Serialize<bool>(useLocalInitialPos, name: "useLocalInitialPos", options: CSerializerObject.Options.BoolAsByte);
			} else {
				fx = s.SerializeObject<StringID>(fx, name: "fx");
				stop = s.Serialize<bool>(stop, name: "stop");
			}
		}
		public override uint? ClassCRC => 0xBC2071D6;
	}
}

