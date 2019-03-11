using UnityEngine;

namespace UbiArt.ITF {
	public partial class AnimLightComponent : GraphicComponent {
		[Serialize("syncOffset"          )] public float syncOffset;
		[Serialize("startOffset"         )] public float startOffset;
		[Serialize("subAnimInfo"         )] public SubAnimSet subAnimInfo;
		[Serialize("subSkeleton"         )] public StringID subSkeleton;
		[Serialize("defaultAnim"         )] public StringID defaultAnim;
		[Serialize("useZOffset"          )] public bool useZOffset;
		[Serialize("EmitFluid"           )] public bool EmitFluid;
		[Serialize("BasicRender"         )] public bool BasicRender;
		[Serialize("lastAnim"            )] public StringID lastAnim;
		[Serialize("playAnim"            )] public StringID playAnim;
		[Serialize("playAnimFrames"      )] public uint playAnimFrames;
		[Serialize("currentFrameSubAnims")] public CList<AnimLightFrameInfo> currentFrameSubAnims;
		[Serialize("animInstance"        )] public Path animInstance;
		[Serialize("currentFrameSubAnims")] public Placeholder currentFrameSubAnims;
		[Serialize("MatShader"           )] public Path MatShader;
		protected override void SerializeImpl(CSerializerObject s) {
			base.SerializeImpl(s);
			if (Settings.s.game == Settings.Game.RO) {
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
			} else {
				if (s.HasFlags(SerializeFlags.Default)) {
					SerializeField(s, nameof(syncOffset));
					SerializeField(s, nameof(startOffset));
					SerializeField(s, nameof(subAnimInfo));
					SerializeField(s, nameof(subSkeleton));
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

