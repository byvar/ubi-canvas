using System.Collections.Generic;
using System.Linq;

namespace UbiArt.ITF {
	public partial class Scene {
		// Returns whether actor was added to scene successfully
		public bool AddActor(Actor a, string name) {
			if (ACTORS != null && a != null && !ACTORS.Any(ac => ac.obj != null && ac.obj == a)) {
				if (a.USERFRIENDLY == null || a.USERFRIENDLY.Length == 0) {
					a.USERFRIENDLY = name;
					int i = 0;
					while(ACTORS.Any(ac => !ac.IsNull && ac.obj.USERFRIENDLY == a.USERFRIENDLY)) {
						a.USERFRIENDLY = $"{name}@{i}";
						i++;
					}
				}
				ACTORS.Add(new Generic<Actor>(a));

				return true;
			}
			return false;
		}


		protected override void OnPreSerialize(CSerializerObject s) {
			base.OnPreSerialize(s);
			Reinit(s.Context, s.Settings);
		}

		public Scene() { }
		public Scene(Context c) {
			UbiArtContext = c;
		}

		Settings previousSettings = null;
		protected virtual void Reinit(Context c, Settings settings) {
			if (previousSettings != null) {
				if (previousSettings.game != settings.game) {
					ENGINE_VERSION = 0;
					/*if (FRISE != null) {
						foreach (var fr in FRISE) {
							if (fr.ConfigName?.filename == "greecemap_clouds.fcg"
								|| fr.ConfigName?.filename == "greecemap_clouds_atlas.fcg"){
								//|| fr.ConfigName?.filename == "toadstorymap_background01.fcg") {
								fr.ConfigName = new Path("world/landofthedead/deadjail/playground/decostructure/wallsquare.fcg");
							}
						}
					}*/
					//ACTORS = null;

					/*if (ACTORS != null) {
						List<Generic<Actor>> RemovedComponents = new List<Generic<Actor>>();
						// Check components, remove all that don't have the right gameflags
						for (int i = 0; i < ACTORS.Count; i++) {
							var compobj = ACTORS[i].obj;
							compobj.parentBind = null;
							if (compobj is SubSceneActor ssa) {
								if((ssa.SCENE?.read ?? false) == false)
									RemovedComponents.Add(ACTORS[i]);
							} else {
								RemovedComponents.Add(ACTORS[i]);
							}
						}
						foreach (var comp in RemovedComponents) {
							ACTORS.Remove(comp);
						}
					}*/
					/*f (FRISE?.Count == 5) {
						var newFrise = new CListO<Frise>();
						for (int i = 0; i < 5; i++) {
							if (i == 0 || i == 2) {
								newFrise.Add(FRISE[i]);
							}
						}
						FRISE = newFrise;
					}*/
				}
			}
			previousSettings = settings;
		}
	}
}
