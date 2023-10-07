namespace FreeSR.Proto
{
	using ProtoBuf;

	[ProtoContract]
	public class FKGEPIAHAMO
	{
		[ProtoMember(4)] public LineupInfo Lineup;
		[ProtoMember(3)] public SceneInfo Scene;
	}

}
