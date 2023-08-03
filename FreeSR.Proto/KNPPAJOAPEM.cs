namespace FreeSR.Proto
{
	using ProtoBuf;

	[ProtoContract]
	public class KNPPAJOAPEM
	{
		[ProtoMember(6)] public int Level;
		[ProtoMember(13)] public int BuffId;
	}
	
}
