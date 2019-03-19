using UnityEngine;

namespace UbiArt.ITF {
	[Games(GameFlags.RA)]
	public partial class SpawnActorPathTuto : CSerializable {
		[Serialize("tutoType"    )] public uint tutoType;
		[Serialize("tutoCycle"   )] public uint tutoCycle;
		[Serialize("isDrc"       )] public bool isDrc;
		[Serialize("defaultActor")] public Path defaultActor;
		[Serialize("DRC"         )] public Path DRC;
		[Serialize("Pad"         )] public Path Pad;
		[Serialize("WiiRemote"   )] public Path WiiRemote;
		[Serialize("ClassicPad"  )] public Path ClassicPad;
		[Serialize("NunChuk"     )] public Path NunChuk;
		[Serialize("X360"        )] public Path X360;
		[Serialize("Ps3"         )] public Path Ps3;
		protected override void SerializeImpl(CSerializerObject s) {
			base.SerializeImpl(s);
			SerializeField(s, nameof(tutoType));
			SerializeField(s, nameof(tutoCycle));
			SerializeField(s, nameof(isDrc));
			SerializeField(s, nameof(defaultActor));
			SerializeField(s, nameof(DRC));
			SerializeField(s, nameof(Pad));
			SerializeField(s, nameof(WiiRemote));
			SerializeField(s, nameof(ClassicPad));
			SerializeField(s, nameof(NunChuk));
			SerializeField(s, nameof(X360));
			SerializeField(s, nameof(Ps3));
		}
	}
}

