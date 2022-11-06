using UnityEngine;

namespace UbiArt.ITF {
	[Games(GameFlags.RL | GameFlags.RA)]
	public partial class RO2_BreakablePropsManagerComponent : ActorComponent {
		public uint lumsGiven;
		public uint lumsDrcGiven;
		public CListP<uint> breakablePropsState;
		public CArrayP<bool> breakablePropsPaint;
		protected override void SerializeImpl(CSerializerObject s) {
			base.SerializeImpl(s);
			lumsGiven = s.Serialize<uint>(lumsGiven, name: "lumsGiven");
			lumsDrcGiven = s.Serialize<uint>(lumsDrcGiven, name: "lumsDrcGiven");
			if (s.HasFlags(SerializeFlags.Persistent)) {
				breakablePropsState = s.SerializeObject<CListP<uint>>(breakablePropsState, name: "breakablePropsState");
				breakablePropsPaint = s.SerializeObject<CArrayP<bool>>(breakablePropsPaint, name: "breakablePropsPaint");
			}
		}
		public override uint? ClassCRC => 0xF2DC9CA7;
	}
}

