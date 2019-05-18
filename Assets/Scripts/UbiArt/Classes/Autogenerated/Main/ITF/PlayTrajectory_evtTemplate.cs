using UnityEngine;

namespace UbiArt.ITF {
	[Games(GameFlags.RA | GameFlags.RFR | GameFlags.RO | GameFlags.RL | GameFlags.COL | GameFlags.VH)]
	public partial class PlayTrajectory_evtTemplate : SequenceEventWithActor_Template {
		[Serialize("coeffOneCamera"              )] public float coeffOneCamera;
		[Serialize("coeffOneCameraOut"           )] public float coeffOneCameraOut;
		[Serialize("ParentFriendlyName"          )] public ObjectPath ParentFriendlyName;
		[Serialize("ParentID"                    )] public StringID ParentID;
		[Serialize("ParentBone"                  )] public string ParentBone;
		[Serialize("RestoreInitialPos"           )] public bool RestoreInitialPos;
		[Serialize("Keyframes"                   )] public Trajectory_Template Keyframes;
		[Serialize("startFrameCameraBlend"       )] public int startFrameCameraBlend;
		[Serialize("coeffCameraIn"               )] public float coeffCameraIn;
		[Serialize("coeffCameraOut"              )] public float coeffCameraOut;
		[Serialize("cameraMask"                  )] public uint cameraMask;
		[Serialize("Flip"                        )] public BoolEventList Flip;
		[Serialize("Color"                       )] public Spline Color;
		[Serialize("Alpha"                       )] public Spline Alpha;
		[Serialize("FogColor"                    )] public Spline FogColor;
		[Serialize("FogAlpha"                    )] public Spline FogAlpha;
		[Serialize("UseSequenceInitialPos"       )] public bool UseSequenceInitialPos;
		[Serialize("MustUpdateChildrenPos"       )] public bool MustUpdateChildrenPos;
		[Serialize("coeffTwoCamera"              )] public float coeffTwoCamera;
		[Serialize("coeffTwoCameraOut"           )] public float coeffTwoCameraOut;
		[Serialize("depthZ"                      )] public float depthZ;
		[Serialize("actorInterpoDuration"        )] public float actorInterpoDuration;
		[Serialize("actorInterpoSetFlipFromSpeed")] public int actorInterpoSetFlipFromSpeed;
		[Serialize("dynamicDeltaFogZ"            )] public bool dynamicDeltaFogZ;

		protected override void SerializeImpl(CSerializerObject s) {
			base.SerializeImpl(s);
			if (Settings.s.game == Settings.Game.RFR || Settings.s.game == Settings.Game.RO) {
				SerializeField(s, nameof(RestoreInitialPos));
				SerializeField(s, nameof(Keyframes));
				SerializeField(s, nameof(startFrameCameraBlend));
				SerializeField(s, nameof(coeffOneCamera));
				SerializeField(s, nameof(coeffTwoCamera));
				SerializeField(s, nameof(coeffOneCameraOut));
				SerializeField(s, nameof(coeffTwoCameraOut));
			} else if (Settings.s.game == Settings.Game.RL) {
				if (s.HasFlags(SerializeFlags.Flags8)) {
					SerializeField(s, nameof(coeffOneCamera));
					SerializeField(s, nameof(coeffOneCameraOut));
				}
				SerializeField(s, nameof(ParentFriendlyName));
				SerializeField(s, nameof(ParentID));
				SerializeField(s, nameof(ParentBone));
				SerializeField(s, nameof(RestoreInitialPos));
				SerializeField(s, nameof(Keyframes));
				SerializeField(s, nameof(startFrameCameraBlend));
				SerializeField(s, nameof(coeffCameraIn));
				SerializeField(s, nameof(coeffCameraOut));
				SerializeField(s, nameof(depthZ));
				SerializeField(s, nameof(dynamicDeltaFogZ));
				SerializeField(s, nameof(cameraMask));
				SerializeField(s, nameof(Flip));
				SerializeField(s, nameof(Color));
				SerializeField(s, nameof(Alpha));
				SerializeField(s, nameof(UseSequenceInitialPos));
			} else if (Settings.s.game == Settings.Game.COL) {
				if (s.HasFlags(SerializeFlags.Flags8)) {
					SerializeField(s, nameof(coeffOneCamera));
					SerializeField(s, nameof(coeffOneCameraOut));
				}
				SerializeField(s, nameof(ParentFriendlyName));
				SerializeField(s, nameof(ParentID));
				SerializeField(s, nameof(ParentBone));
				SerializeField(s, nameof(RestoreInitialPos), boolAsByte: true);
				SerializeField(s, nameof(Keyframes));
				SerializeField(s, nameof(startFrameCameraBlend));
				SerializeField(s, nameof(actorInterpoDuration));
				SerializeField(s, nameof(actorInterpoSetFlipFromSpeed));
				SerializeField(s, nameof(coeffCameraIn));
				SerializeField(s, nameof(coeffCameraOut));
				SerializeField(s, nameof(depthZ));
				SerializeField(s, nameof(dynamicDeltaFogZ), boolAsByte: true);
				SerializeField(s, nameof(cameraMask));
				SerializeField(s, nameof(Flip));
				SerializeField(s, nameof(Color));
				SerializeField(s, nameof(Alpha));
				SerializeField(s, nameof(UseSequenceInitialPos), boolAsByte: true);
			} else if (Settings.s.game == Settings.Game.VH) {
				if (s.HasFlags(SerializeFlags.Flags8)) {
					SerializeField(s, nameof(coeffOneCamera));
					SerializeField(s, nameof(coeffOneCameraOut));
				}
				SerializeField(s, nameof(ParentFriendlyName));
				SerializeField(s, nameof(ParentID));
				SerializeField(s, nameof(ParentBone));
				SerializeField(s, nameof(RestoreInitialPos));
				SerializeField(s, nameof(Keyframes));
				SerializeField(s, nameof(startFrameCameraBlend));
				SerializeField(s, nameof(coeffCameraIn));
				SerializeField(s, nameof(coeffCameraOut));
				SerializeField(s, nameof(cameraMask));
				SerializeField(s, nameof(Flip));
				SerializeField(s, nameof(Color));
				SerializeField(s, nameof(Alpha));
				SerializeField(s, nameof(UseSequenceInitialPos));
			} else {
				if (s.HasFlags(SerializeFlags.Flags8)) {
					SerializeField(s, nameof(coeffOneCamera));
					SerializeField(s, nameof(coeffOneCameraOut));
				}
				SerializeField(s, nameof(ParentFriendlyName));
				SerializeField(s, nameof(ParentID));
				SerializeField(s, nameof(ParentBone));
				SerializeField(s, nameof(RestoreInitialPos));
				SerializeField(s, nameof(Keyframes));
				SerializeField(s, nameof(startFrameCameraBlend));
				SerializeField(s, nameof(coeffCameraIn));
				SerializeField(s, nameof(coeffCameraOut));
				SerializeField(s, nameof(cameraMask));
				SerializeField(s, nameof(Flip));
				SerializeField(s, nameof(Color));
				SerializeField(s, nameof(Alpha));
				SerializeField(s, nameof(FogColor));
				SerializeField(s, nameof(FogAlpha));
				SerializeField(s, nameof(UseSequenceInitialPos));
				SerializeField(s, nameof(MustUpdateChildrenPos));
			}
		}
		public override uint? ClassCRC => 0xA1DA8606;
	}
}

