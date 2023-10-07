namespace FreeSR.Proto
{
	using ProtoBuf;

	[ProtoContract]
	public class IBAAPCGGNIF
	{
		[ProtoMember(7)] public SceneInfo Scene;
		[ProtoMember(6)] public int Retcode;
		[ProtoMember(1)] public LineupInfo Lineup;
		[ProtoMember(13)] public OHCCLDKPFFG Jmlkgnpdnee;
	}

}
