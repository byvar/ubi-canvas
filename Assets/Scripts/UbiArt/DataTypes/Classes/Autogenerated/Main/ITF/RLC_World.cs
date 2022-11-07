namespace UbiArt.ITF {
	[Games(GameFlags.RM)]
	public partial class RLC_World : CSerializable {
		public uint LineIdName;
		public PathRef Path;
		public Enum_UnlockType UnlockType;
		public CList<RLC_Map> Maps;
		protected override void SerializeImpl(CSerializerObject s) {
			base.SerializeImpl(s);
			LineIdName = s.Serialize<uint>(LineIdName, name: "LineIdName");
			Path = s.SerializeObject<PathRef>(Path, name: "Path");
			UnlockType = s.Serialize<Enum_UnlockType>(UnlockType, name: "UnlockType");
			Maps = s.SerializeObject<CList<RLC_Map>>(Maps, name: "Maps");
		}
		public enum Enum_UnlockType {
			[Serialize("ByDefault"                     )] ByDefault = 0,
			[Serialize("ReachLastWorldCompletionTarget")] ReachLastWorldCompletionTarget = 1,
			[Serialize("BeatAllPreviousBoss"           )] BeatAllPreviousBoss = 2,
		}
		public override uint? ClassCRC => 0xF71095C6;
	}
}

