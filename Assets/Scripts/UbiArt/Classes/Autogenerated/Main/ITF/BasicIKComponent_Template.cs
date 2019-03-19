using UnityEngine;

namespace UbiArt.ITF {
	[Games(GameFlags.RA | GameFlags.VH)]
	public partial class BasicIKComponent_Template : ActorComponent_Template {
		[Serialize("defaultProcess"     )] public bool defaultProcess;
		[Serialize("CArray<StringID>__0")] public CArray<StringID> CArray_StringID__0;
		[Serialize("bool__1"            )] public bool bool__1;
		protected override void SerializeImpl(CSerializerObject s) {
			base.SerializeImpl(s);
			if (Settings.s.game == Settings.Game.VH) {
				SerializeField(s, nameof(CArray_StringID__0));
				SerializeField(s, nameof(bool__1));
			} else {
				SerializeField(s, nameof(defaultProcess));
			}
		}
		public override uint? ClassCRC => 0xBF2A28E6;
	}
}

