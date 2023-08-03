namespace FreeSR.Proto
{
	using ProtoBuf;

	[ProtoContract]
	public class SceneMonsterWave
	{
		[ProtoMember(9)] public List<EEPAFHEBIKG> MonsterList;
		[ProtoMember(11)] public HJDGNJOCKCM MonsterParam;
		[ProtoMember(10)] public List<ItemList> DropList;
	}
	
}
