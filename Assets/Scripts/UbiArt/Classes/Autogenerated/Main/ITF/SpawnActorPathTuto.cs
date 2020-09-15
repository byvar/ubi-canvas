using UnityEngine;

namespace UbiArt.ITF {
	[Games(GameFlags.RA)]
	public partial class SpawnActorPathTuto : CSerializable {
		public uint tutoType;
		public uint tutoCycle;
		public bool isDrc;
		public Path defaultActor;
		public Path DRC;
		public Path Pad;
		public Path WiiRemote;
		public Path ClassicPad;
		public Path NunChuk;
		public Path X360;
		public Path Ps3;
		protected override void SerializeImpl(CSerializerObject s) {
			base.SerializeImpl(s);
			tutoType = s.Serialize<uint>(tutoType, name: "tutoType");
			tutoCycle = s.Serialize<uint>(tutoCycle, name: "tutoCycle");
			isDrc = s.Serialize<bool>(isDrc, name: "isDrc");
			defaultActor = s.SerializeObject<Path>(defaultActor, name: "defaultActor");
			DRC = s.SerializeObject<Path>(DRC, name: "DRC");
			Pad = s.SerializeObject<Path>(Pad, name: "Pad");
			WiiRemote = s.SerializeObject<Path>(WiiRemote, name: "WiiRemote");
			ClassicPad = s.SerializeObject<Path>(ClassicPad, name: "ClassicPad");
			NunChuk = s.SerializeObject<Path>(NunChuk, name: "NunChuk");
			X360 = s.SerializeObject<Path>(X360, name: "X360");
			Ps3 = s.SerializeObject<Path>(Ps3, name: "Ps3");
		}
	}
}

