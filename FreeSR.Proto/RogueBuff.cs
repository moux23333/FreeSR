namespace FreeSR.Proto
{
	using ProtoBuf;

	[ProtoContract]
	public class RogueBuff
	{
		[ProtoMember(7)] public int BuffId;
		[ProtoMember(15)] public int Level;
	}
	
}
