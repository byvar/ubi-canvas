using UnityEngine;

namespace UbiArt.ITF {
	[Games(GameFlags.COL)]
	public partial class COL_AudioEventManager_Template : CSerializable {
		public Placeholder swapControllerIdSoundDescriptor;
		public Placeholder musicEventEnteredMenu;
		public Placeholder musicEventExitedMenu;
		public Placeholder enterStartScreen;
		public Placeholder enterLoadingScreen;
		public Placeholder enterExploration;
		public Placeholder exitExploration;
		public Placeholder enterCinematicDialog;
		public Placeholder exitCinematicDialog;
		public Placeholder enterMovie;
		public Placeholder exitMovie;
		public StringID musicVolumeRtpcGuid;
		public StringID sfxVolumeRtpcGuid;
		public StringID musicStateGroup;
		public Placeholder pauseAllSoundDescriptor;
		public Placeholder resumeAllSoundDescriptor;
		protected override void SerializeImpl(CSerializerObject s) {
			base.SerializeImpl(s);
			swapControllerIdSoundDescriptor = s.SerializeObject<Placeholder>(swapControllerIdSoundDescriptor, name: "swapControllerIdSoundDescriptor");
			musicEventEnteredMenu = s.SerializeObject<Placeholder>(musicEventEnteredMenu, name: "musicEventEnteredMenu");
			musicEventExitedMenu = s.SerializeObject<Placeholder>(musicEventExitedMenu, name: "musicEventExitedMenu");
			enterStartScreen = s.SerializeObject<Placeholder>(enterStartScreen, name: "enterStartScreen");
			enterLoadingScreen = s.SerializeObject<Placeholder>(enterLoadingScreen, name: "enterLoadingScreen");
			enterExploration = s.SerializeObject<Placeholder>(enterExploration, name: "enterExploration");
			exitExploration = s.SerializeObject<Placeholder>(exitExploration, name: "exitExploration");
			enterCinematicDialog = s.SerializeObject<Placeholder>(enterCinematicDialog, name: "enterCinematicDialog");
			exitCinematicDialog = s.SerializeObject<Placeholder>(exitCinematicDialog, name: "exitCinematicDialog");
			enterMovie = s.SerializeObject<Placeholder>(enterMovie, name: "enterMovie");
			exitMovie = s.SerializeObject<Placeholder>(exitMovie, name: "exitMovie");
			musicVolumeRtpcGuid = s.SerializeObject<StringID>(musicVolumeRtpcGuid, name: "musicVolumeRtpcGuid");
			sfxVolumeRtpcGuid = s.SerializeObject<StringID>(sfxVolumeRtpcGuid, name: "sfxVolumeRtpcGuid");
			musicStateGroup = s.SerializeObject<StringID>(musicStateGroup, name: "musicStateGroup");
			pauseAllSoundDescriptor = s.SerializeObject<Placeholder>(pauseAllSoundDescriptor, name: "pauseAllSoundDescriptor");
			resumeAllSoundDescriptor = s.SerializeObject<Placeholder>(resumeAllSoundDescriptor, name: "resumeAllSoundDescriptor");
		}
		public override uint? ClassCRC => 0x2E949D2F;
	}
}

