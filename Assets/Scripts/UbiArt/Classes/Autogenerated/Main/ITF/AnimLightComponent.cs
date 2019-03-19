using UnityEngine;

namespace UbiArt.ITF {
	[Games(GameFlags.RA | GameFlags.RJR | GameFlags.RFR | GameFlags.RO | GameFlags.RL | GameFlags.COL | GameFlags.VH)]
	public partial class AnimLightComponent : GraphicComponent {
		[Serialize("syncOffset"          )] public float syncOffset;
		[Serialize("startOffset"         )] public float startOffset;
		[Serialize("subAnimInfo"         )] public SubAnimSet subAnimInfo;
		[Serialize("MatShader"           )] public Path MatShader;
		[Serialize("subSkeleton"         )] public StringID subSkeleton;
		[Serialize("defaultAnim"         )] public LocalizedPath defaultAnim;
		[Serialize("defaultAnim"         )] public StringID defaultAnim;
		[Serialize("useZOffset"          )] public bool useZOffset;
		[Serialize("EmitFluid"           )] public bool EmitFluid;
		[Serialize("BasicRender"         )] public bool BasicRender;
		[Serialize("lastAnim"            )] public StringID lastAnim;
		[Serialize("playAnim"            )] public StringID playAnim;
		[Serialize("playAnimFrames"      )] public uint playAnimFrames;
		[Serialize("currentFrameSubAnims")] public CList<AnimLightFrameInfo> currentFrameSubAnims;
		[Serialize("animInstance"        )] public Path animInstance;
		[Serialize("float__0"            )] public float float__0;
		[Serialize("float__1"            )] public float float__1;
		[Serialize("SubAnimSet__2"       )] public SubAnimSet SubAnimSet__2;
		[Serialize("Path__3"             )] public Path Path__3;
		[Serialize("StringID__4"         )] public StringID StringID__4;
		[Serialize("bool__5"             )] public bool bool__5;
		[Serialize("bool__6"             )] public bool bool__6;
		[Serialize("bool__7"             )] public bool bool__7;
		[Serialize("StringID__8"         )] public StringID StringID__8;
		[Serialize("bool__9"             )] public bool bool__9;
		protected override void SerializeImpl(CSerializerObject s) {
			base.SerializeImpl(s);
			if (Settings.s.game == Settings.Game.RJR || Settings.s.game == Settings.Game.RFR || Settings.s.game == Settings.Game.RO) {
				if (s.HasFlags(SerializeFlags.Default)) {
					SerializeField(s, nameof(syncOffset));
					SerializeField(s, nameof(animInstance));
				}
				if (s.HasFlags(SerializeFlags.Persistent)) {
					SerializeField(s, nameof(playAnim));
					SerializeField(s, nameof(playAnimFrames));
					SerializeField(s, nameof(currentFrameSubAnims));
				}
			} else if (Settings.s.game == Settings.Game.RL) {
				if (s.HasFlags(SerializeFlags.Default)) {
					SerializeField(s, nameof(syncOffset));
					SerializeField(s, nameof(startOffset));
					SerializeField(s, nameof(subAnimInfo));
					SerializeField(s, nameof(MatShader));
					SerializeField(s, nameof(subSkeleton));
					SerializeField(s, nameof(defaultAnim));
					SerializeField(s, nameof(useZOffset));
				}
				if (s.HasFlags(SerializeFlags.Persistent)) {
					SerializeField(s, nameof(playAnim));
					SerializeField(s, nameof(playAnimFrames));
					SerializeField(s, nameof(currentFrameSubAnims));
				}
			} else if (Settings.s.game == Settings.Game.COL) {
				if (s.HasFlags(SerializeFlags.Default)) {
					SerializeField(s, nameof(syncOffset));
					SerializeField(s, nameof(startOffset));
					SerializeField(s, nameof(MatShader));
					SerializeField(s, nameof(subSkeleton));
					SerializeField(s, nameof(defaultAnim));
					SerializeField(s, nameof(useZOffset));
					SerializeField(s, nameof(useZOffset));
				}
				if (s.HasFlags(SerializeFlags.Persistent)) {
					SerializeField(s, nameof(playAnim));
					SerializeField(s, nameof(playAnimFrames));
				}
			} else if (Settings.s.game == Settings.Game.VH) {
				if (s.HasFlags(SerializeFlags.Default)) {
					SerializeField(s, nameof(float__0));
					SerializeField(s, nameof(float__1));
					SerializeField(s, nameof(SubAnimSet__2));
					SerializeField(s, nameof(Path__3));
					SerializeField(s, nameof(StringID__4));
					SerializeField(s, nameof(bool__5));
					SerializeField(s, nameof(bool__6));
					SerializeField(s, nameof(bool__7));
					SerializeField(s, nameof(StringID__8));
					SerializeField(s, nameof(bool__9));
				}
				if (s.HasFlags(SerializeFlags.Persistent)) {
					SerializeField(s, nameof(lastAnim));
					SerializeField(s, nameof(playAnim));
					SerializeField(s, nameof(playAnimFrames));
					SerializeField(s, nameof(currentFrameSubAnims));
				}
			} else {
				if (s.HasFlags(SerializeFlags.Default)) {
					SerializeField(s, nameof(syncOffset));
					SerializeField(s, nameof(startOffset));
					SerializeField(s, nameof(subAnimInfo));
					SerializeField(s, nameof(MatShader));
					SerializeField(s, nameof(subSkeleton));
					SerializeField(s, nameof(defaultAnim));
					SerializeField(s, nameof(defaultAnim));
					SerializeField(s, nameof(useZOffset));
				}
				if (s.HasFlags(SerializeFlags.Flags8)) {
					SerializeField(s, nameof(EmitFluid));
					SerializeField(s, nameof(BasicRender));
				}
				if (s.HasFlags(SerializeFlags.Persistent)) {
					SerializeField(s, nameof(lastAnim));
					SerializeField(s, nameof(playAnim));
					SerializeField(s, nameof(playAnimFrames));
					SerializeField(s, nameof(currentFrameSubAnims));
				}
			}
		}
		public override uint? ClassCRC => 0xA6E4EFBA;
	}
}

