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
		[Serialize("RestoreInitialPos"           )] public int RestoreInitialPos;
		[Serialize("coeffTwoCamera"              )] public float coeffTwoCamera;
		[Serialize("coeffTwoCameraOut"           )] public float coeffTwoCameraOut;
		[Serialize("depthZ"                      )] public float depthZ;
		[Serialize("dynamicDeltaFogZ"            )] public int dynamicDeltaFogZ;
		[Serialize("actorInterpoDuration"        )] public float actorInterpoDuration;
		[Serialize("actorInterpoSetFlipFromSpeed")] public int actorInterpoSetFlipFromSpeed;
		[Serialize("dynamicDeltaFogZ"            )] public bool dynamicDeltaFogZ;
		[Serialize("float__0"                    )] public float float__0;
		[Serialize("float__1"                    )] public float float__1;
		[Serialize("ObjectPath__2"               )] public ObjectPath ObjectPath__2;
		[Serialize("StringID__3"                 )] public StringID StringID__3;
		[Serialize("string__4"                   )] public string string__4;
		[Serialize("bool__5"                     )] public bool bool__5;
		[Serialize("Trajectory_Template__6"      )] public Trajectory_Template Trajectory_Template__6;
		[Serialize("int__7"                      )] public int int__7;
		[Serialize("float__8"                    )] public float float__8;
		[Serialize("float__9"                    )] public float float__9;
		[Serialize("uint__10"                    )] public uint uint__10;
		[Serialize("BoolEventList__11"           )] public BoolEventList BoolEventList__11;
		[Serialize("Spline__12"                  )] public Spline Spline__12;
		[Serialize("Spline__13"                  )] public Spline Spline__13;
		[Serialize("bool__14"                    )] public bool bool__14;
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
					SerializeField(s, nameof(float__0));
					SerializeField(s, nameof(float__1));
				}
				SerializeField(s, nameof(ObjectPath__2));
				SerializeField(s, nameof(StringID__3));
				SerializeField(s, nameof(string__4));
				SerializeField(s, nameof(bool__5));
				SerializeField(s, nameof(Trajectory_Template__6));
				SerializeField(s, nameof(int__7));
				SerializeField(s, nameof(float__8));
				SerializeField(s, nameof(float__9));
				SerializeField(s, nameof(uint__10));
				SerializeField(s, nameof(BoolEventList__11));
				SerializeField(s, nameof(Spline__12));
				SerializeField(s, nameof(Spline__13));
				SerializeField(s, nameof(bool__14));
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

