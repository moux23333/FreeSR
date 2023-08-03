namespace FreeSR.Proto
{
	using ProtoBuf;

	[ProtoContract]
	public class SceneNpcMonsterInfo
	{
		[ProtoMember(10)] public int MonsterId;
		[ProtoMember(14)] public int WorldLevel;
		[ProtoMember(7)] public bool OHENKPOLAND;
		[ProtoMember(13)] public bool HCLMNPDNPKL;
		[ProtoMember(6)] public int EventId;
		[ProtoMember(11)] public GKKCMAPELHB ExtraInfo;
	}
	
}
