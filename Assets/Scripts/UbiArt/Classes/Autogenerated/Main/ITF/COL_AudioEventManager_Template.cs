using UnityEngine;

namespace UbiArt.ITF {
	[Games(GameFlags.COL)]
	public partial class COL_AudioEventManager_Template : CSerializable {
		[Serialize("swapControllerIdSoundDescriptor")] public Placeholder swapControllerIdSoundDescriptor;
		[Serialize("musicEventEnteredMenu"          )] public Placeholder musicEventEnteredMenu;
		[Serialize("musicEventExitedMenu"           )] public Placeholder musicEventExitedMenu;
		[Serialize("enterStartScreen"               )] public Placeholder enterStartScreen;
		[Serialize("enterLoadingScreen"             )] public Placeholder enterLoadingScreen;
		[Serialize("enterExploration"               )] public Placeholder enterExploration;
		[Serialize("exitExploration"                )] public Placeholder exitExploration;
		[Serialize("enterCinematicDialog"           )] public Placeholder enterCinematicDialog;
		[Serialize("exitCinematicDialog"            )] public Placeholder exitCinematicDialog;
		[Serialize("enterMovie"                     )] public Placeholder enterMovie;
		[Serialize("exitMovie"                      )] public Placeholder exitMovie;
		[Serialize("musicVolumeRtpcGuid"            )] public StringID musicVolumeRtpcGuid;
		[Serialize("sfxVolumeRtpcGuid"              )] public StringID sfxVolumeRtpcGuid;
		[Serialize("musicStateGroup"                )] public StringID musicStateGroup;
		[Serialize("pauseAllSoundDescriptor"        )] public Placeholder pauseAllSoundDescriptor;
		[Serialize("resumeAllSoundDescriptor"       )] public Placeholder resumeAllSoundDescriptor;
		protected override void SerializeImpl(CSerializerObject s) {
			base.SerializeImpl(s);
			SerializeField(s, nameof(swapControllerIdSoundDescriptor));
			SerializeField(s, nameof(musicEventEnteredMenu));
			SerializeField(s, nameof(musicEventExitedMenu));
			SerializeField(s, nameof(enterStartScreen));
			SerializeField(s, nameof(enterLoadingScreen));
			SerializeField(s, nameof(enterExploration));
			SerializeField(s, nameof(exitExploration));
			SerializeField(s, nameof(enterCinematicDialog));
			SerializeField(s, nameof(exitCinematicDialog));
			SerializeField(s, nameof(enterMovie));
			SerializeField(s, nameof(exitMovie));
			SerializeField(s, nameof(musicVolumeRtpcGuid));
			SerializeField(s, nameof(sfxVolumeRtpcGuid));
			SerializeField(s, nameof(musicStateGroup));
			SerializeField(s, nameof(pauseAllSoundDescriptor));
			SerializeField(s, nameof(resumeAllSoundDescriptor));
		}
		public override uint? ClassCRC => 0x2E949D2F;
	}
}

