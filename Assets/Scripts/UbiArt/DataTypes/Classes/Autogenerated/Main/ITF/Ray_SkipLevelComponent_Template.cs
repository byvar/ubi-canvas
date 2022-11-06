using UnityEngine;

namespace UbiArt.ITF {
	[Games(GameFlags.RO)]
	public partial class Ray_SkipLevelComponent_Template : ActorComponent_Template {
		public Path textPath;
		public Vec2d animSize;
		public Vec2d textAnimSize;
		public Vec2d screenPos;
		public Vec2d textScreenPos;
		public StringID appearAnim;
		public StringID disappearAnim;
		public StringID talkAnim;
		public LocalisationId locId;
		public uint rank;
		public uint textRank;
		public uint contextIconRank;
		protected override void SerializeImpl(CSerializerObject s) {
			base.SerializeImpl(s);
			textPath = s.SerializeObject<Path>(textPath, name: "textPath");
			animSize = s.SerializeObject<Vec2d>(animSize, name: "animSize");
			textAnimSize = s.SerializeObject<Vec2d>(textAnimSize, name: "textAnimSize");
			screenPos = s.SerializeObject<Vec2d>(screenPos, name: "screenPos");
			textScreenPos = s.SerializeObject<Vec2d>(textScreenPos, name: "textScreenPos");
			appearAnim = s.SerializeObject<StringID>(appearAnim, name: "appearAnim");
			disappearAnim = s.SerializeObject<StringID>(disappearAnim, name: "disappearAnim");
			talkAnim = s.SerializeObject<StringID>(talkAnim, name: "talkAnim");
			locId = s.SerializeObject<LocalisationId>(locId, name: "locId");
			rank = s.Serialize<uint>(rank, name: "rank");
			textRank = s.Serialize<uint>(textRank, name: "textRank");
			contextIconRank = s.Serialize<uint>(contextIconRank, name: "contextIconRank");
		}
		public override uint? ClassCRC => 0x7B03C524;
	}
}

