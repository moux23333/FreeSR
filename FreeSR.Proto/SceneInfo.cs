namespace FreeSR.Proto
{
	using ProtoBuf;

	[ProtoContract]
	public class SceneInfo
	{
		[ProtoMember(2028)] public Dictionary<string, int> Ffhkboligaj;
		[ProtoMember(1)] public int Bkmbkahohif; 
		[ProtoMember(6)] public int FloorId;
		[ProtoMember(12)] public List<int> LightenSectionList;
		[ProtoMember(7)] public int PlaneId;
		[ProtoMember(11)] public List<SceneEntityInfo> EntityList;
		[ProtoMember(10)] public MechanismBarInfo Abdcmnblepa;
		[ProtoMember(1496)] public List<LCKCOFLDGDO> Ilapleopbed;
		[ProtoMember(8)] public Dictionary<int, LPKDNGEDMDO> Kocfnldmphi;
		[ProtoMember(14)] public int EntryId;
		[ProtoMember(2)] public List<int> Oondmdfablj;
		[ProtoMember(5)] public int Admbbnbnibk;
		[ProtoMember(13)] public int LeaderEntityId;
		[ProtoMember(4)] public List<OLEJDNBFIJI> CustomDataList;
		[ProtoMember(1882)] public List<NFDPJPAEOEC> Ogofbaicehd;
		[ProtoMember(3)] public List<BuffInfo> EnvBuffList;
		[ProtoMember(15)] public int GameModeType;
		[ProtoMember(9)] public List<EntityBuffInfo> EntityBuffList;
	}

}
