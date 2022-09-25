using UnityEngine;

namespace UbiArt.ITF {
	[Games(GameFlags.RAVersion)]
	public partial class EventPlayAnim : Event {
		public StringID AnimToPlay;
		public bool isAdditive;
		public float AdditiveWeight;
		public bool AdditiveUsePatch;
		public uint NbBlendFrame;
		public bool ResetAnim;
		public uint AnimPriority;
		protected override void SerializeImpl(CSerializerObject s) {
			base.SerializeImpl(s);
			if (s.Settings.game == Settings.Game.VH) {
				AnimToPlay = s.SerializeObject<StringID>(AnimToPlay, name: "AnimToPlay");
				NbBlendFrame = s.Serialize<uint>(NbBlendFrame, name: "NbBlendFrame");
				ResetAnim = s.Serialize<bool>(ResetAnim, name: "ResetAnim");
				AnimPriority = s.Serialize<uint>(AnimPriority, name: "AnimPriority");
			} else {
				AnimToPlay = s.SerializeObject<StringID>(AnimToPlay, name: "AnimToPlay");
				isAdditive = s.Serialize<bool>(isAdditive, name: "isAdditive");
				AdditiveWeight = s.Serialize<float>(AdditiveWeight, name: "AdditiveWeight");
				AdditiveUsePatch = s.Serialize<bool>(AdditiveUsePatch, name: "AdditiveUsePatch");
				NbBlendFrame = s.Serialize<uint>(NbBlendFrame, name: "NbBlendFrame");
				ResetAnim = s.Serialize<bool>(ResetAnim, name: "ResetAnim");
				AnimPriority = s.Serialize<uint>(AnimPriority, name: "AnimPriority");
			}
		}
		public override uint? ClassCRC => 0x546A94AF;
	}
}

