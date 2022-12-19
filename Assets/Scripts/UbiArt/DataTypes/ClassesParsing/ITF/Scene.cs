using System;
using System.Collections.Generic;
using System.Linq;
using UnityEditor.Search;

namespace UbiArt.ITF {
	public partial class Scene {
		// Returns whether actor was added to scene successfully
		public bool AddActor(Actor a, string name) {
			if (ACTORS == null) ACTORS = new CArrayO<Generic<Actor>>();
			if (a != null && !ACTORS.Any(ac => ac?.obj == a)) {
				if(string.IsNullOrEmpty(name))
					name = a.USERFRIENDLY;

				if(name != null) {
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
					if (FRISE != null) {
						List<Frise> friseToRemove = new List<Frise>();
						List<Actor> actorsToAdd = new List<Actor>();
						foreach (var fr in FRISE) {
							if (fr.ShouldCreateParentActor(settings)) {
								actorsToAdd.Add(fr.CreateParentActor());
								friseToRemove.Add(fr);
							}
						}
						foreach (var fr in friseToRemove) {
							FRISE.Remove(fr);
						}
						foreach (var act in actorsToAdd) {
							if(ACTORS == null) ACTORS = new CArrayO<Generic<Actor>>();
							ACTORS.Add(new Generic<Actor>(act));
						}
					}
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

		#region Search
		public SearchResult<Pickable> FindPickable(Predicate<Pickable> p, SearchFlags flags = SearchFlags.AllRecursive) {
			if (flags.HasFlag(SearchFlags.Frise)) {
				if (FRISE != null) {
					foreach (var fr in FRISE) {
						if(fr == null) continue;
						if (p(fr)) {
							return new SearchResult<Pickable>() {
								Path = new ObjectPath() { id = fr.USERFRIENDLY },
								Result = fr,
								ContainingScene = this,
								RootScene = this,
							};
						}
					}
				}
			}
			if (flags.HasFlag(SearchFlags.Actors)) {
				if (ACTORS != null) {
					foreach (var act in ACTORS) {
						if(act?.obj == null) continue;
						if (p(act.obj)) {
							return new SearchResult<Pickable>() {
								Path = new ObjectPath() { id = act.obj.USERFRIENDLY },
								Result = act.obj,
								ContainingScene = this,
								RootScene = this,
							};
						}
						if (flags.HasFlag(SearchFlags.Recursive) && act.obj is SubSceneActor ssa && ssa?.SCENE?.value != null) {
							var ss = ssa.SCENE.value;
							var ssResult = ss.FindPickable(p, flags);
							if (ssResult != null) {
								List<ObjectPath.Level> levels = new List<ObjectPath.Level>();
								levels.Add(new ObjectPath.Level() {
									name = ssa.USERFRIENDLY
								});
								if (ssResult.Path.levels != null) {
									foreach (var lev in ssResult.Path.levels) {
										levels.Add(lev);
									}
								}
								var newResult = new SearchResult<Pickable>() {
									RootScene = this,
									ContainingScene = ssResult.ContainingScene,
									Path = new ObjectPath() {
										levels = new CListO<ObjectPath.Level>(levels),
										id = ssResult.Path.id
									},
									Result = ssResult.Result
								};

								return newResult;
							}
						}
					}
				}
			}
			return null;
		}
		public SearchResult<Actor> FindActor(Predicate<Actor> a, SearchFlags flags = SearchFlags.Actors | SearchFlags.Recursive) {
			var pickable = FindPickable(p => a(p as Actor), flags & ~SearchFlags.Frise);
			if (pickable != null) {
				return new SearchResult<Actor>() {
					ContainingScene = pickable.ContainingScene,
					RootScene = pickable.RootScene,
					Path = pickable.Path,
					Result = pickable.Result as Actor
				};
			}
			return null;
		}
		public List<SearchResult<Pickable>> FindPickables(Predicate<Pickable> p, SearchFlags flags = SearchFlags.AllRecursive) {
			List<SearchResult<Pickable>> results = new List<SearchResult<Pickable>>();
			if (flags.HasFlag(SearchFlags.Frise)) {
				if (FRISE != null) {
					foreach (var fr in FRISE) {
						if (fr == null) continue;
						if (p(fr)) {
							results.Add(new SearchResult<Pickable>() {
								Path = new ObjectPath() { id = fr.USERFRIENDLY },
								Result = fr,
								ContainingScene = this,
								RootScene = this,
							});
						}
					}
				}
			}
			if (flags.HasFlag(SearchFlags.Actors)) {
				if (ACTORS != null) {
					foreach (var act in ACTORS) {
						if (act?.obj == null) continue;
						if (p(act.obj)) {
							results.Add(new SearchResult<Pickable>() {
								Path = new ObjectPath() { id = act.obj.USERFRIENDLY },
								Result = act.obj,
								ContainingScene = this,
								RootScene = this,
							});
						}
						if (flags.HasFlag(SearchFlags.Recursive) && act.obj is SubSceneActor ssa && ssa?.SCENE?.value != null) {
							var ss = ssa.SCENE.value;
							var ssResults = ss.FindPickables(p, flags);
							if (ssResults != null && ssResults.Any()) {
								foreach (var ssResult in ssResults) {
									List<ObjectPath.Level> levels = new List<ObjectPath.Level>();
									levels.Add(new ObjectPath.Level() {
										name = ssa.USERFRIENDLY
									});
									if (ssResult.Path.levels != null) {
										foreach (var lev in ssResult.Path.levels) {
											levels.Add(lev);
										}
									}
									var newResult = new SearchResult<Pickable>() {
										RootScene = this,
										ContainingScene = ssResult.ContainingScene,
										Path = new ObjectPath() {
											levels = new CListO<ObjectPath.Level>(levels),
											id = ssResult.Path.id
										},
										Result = ssResult.Result
									};
									results.Add(newResult);
								}
							}
						}
					}
				}
			}
			return results;
		}
		public List<SearchResult<Actor>> FindActors(Predicate<Actor> a, SearchFlags flags = SearchFlags.Actors | SearchFlags.Recursive) {
			List<SearchResult<Actor>> results = new List<SearchResult<Actor>>();
			var pickables = FindPickables(p => a(p as Actor), flags & ~SearchFlags.Frise);
			if (pickables != null) {
				foreach (var pickable in pickables) {
					results.Add(new SearchResult<Actor>() {
						ContainingScene = pickable.ContainingScene,
						RootScene = pickable.RootScene,
						Path = pickable.Path,
						Result = pickable.Result as Actor
					});
				}
			}
			return results;
		}

		[Flags]
		public enum SearchFlags {
			None = 0,
			Actors = 1 << 0,
			Frise = 1 << 1,
			All = Actors | Frise,

			Recursive = 1 << 2,

			AllRecursive = All | Recursive,
		}

		public class SearchResult<T> where T : Pickable {
			public T Result { get; set; }
			public ObjectPath Path { get; set; }
			public Scene RootScene { get; set; }
			public Scene ContainingScene { get; set; }
		}
		#endregion
	}
}
