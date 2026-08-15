using GardenerAPI;
namespace WebApplication1.Interfaces;

public interface IGardenerRepo
{
    List<Gardener> GetAllGardeners();
    Gardener GetGardener(int id);
    Gardener UpdateGardener(int id, Gardener customer);
    void DeleteGardener(int id);
    Gardener AddGardener(Gardener customer);
}