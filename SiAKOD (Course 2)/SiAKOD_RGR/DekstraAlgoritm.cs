using System.Collections.Generic;
using System.Linq;
using System.Windows.Forms;

namespace SiAKOD_RGR
{
    class DekstraAlgoritm
    {
        public List<City> cities;
        public List<Road> roads;
        public City firstCity;
        public Panel paintbox;

        public DekstraAlgoritm(List<City> cities_, List<Road> roads_, Panel paintBox_)
        {
            cities = cities_;
            roads = roads_;
            paintbox = paintBox_;
        }

        public void startAlg(City beginCity)
        {
            if (this.cities.Count() == 0 || this.roads.Count() == 0)
                return;
            else
            {
                firstCity = beginCity;
                Step(beginCity);
                foreach (City city in cities)
                {
                    City anotherCity = getAnotherUncheckedCity();
                    if (anotherCity != null)
                        Step(anotherCity);
                    else
                        break;
                }
            }
        }

        public void Step(City beginCity)
        {
            foreach(City nextCity in getNeighbors(beginCity))
            {
                if (nextCity.isChecked == false)
                {
                    float newValue = beginCity.Value + getRoad(nextCity, beginCity).getWeight();
                    getRoad(nextCity, beginCity).Select();
                    System.Threading.Thread.Sleep(100);
                    paintbox.Refresh();
                    getRoad(nextCity, beginCity).Deselect();
                    if (nextCity.Value > newValue)
                    {
                        nextCity.Value = newValue;
                        nextCity.prevCity = beginCity;
                    }
                }
            }
            beginCity.isChecked = true;
        }

        public List<City> getNeighbors(City beginCity)
        {
            List<City> Neighbors = new List<City>();
            foreach (City city in cities)
            {
                if (beginCity.HasLink(city))
                    Neighbors.Add(city);
            }
            return Neighbors;
        }

        public Road getRoad(City firstcity, City secondcity)
        {
            foreach (Road road in roads)
            {
                if ((road.First == firstcity && road.Second == secondcity) || (road.First == secondcity && road.Second == firstcity))
                    return road;
            }
            return null;
        }

        private City getAnotherUncheckedCity()
        {
            List<City> uncheckedCity = new List<City>();
            foreach (City city in cities)
            {
                if (city.isChecked == false)
                    uncheckedCity.Add(city);
            }
            if (uncheckedCity.Count != 0)
            {
                float minValue = uncheckedCity.First().Value;
                City minCity = uncheckedCity.First();

                foreach (City city in uncheckedCity)
                {
                    if (city.Value < minValue)
                    {
                        minValue = city.Value;
                        minCity = city;
                    }
                }
                return minCity;
            }
            else
                return null;
        }
        
        public List<City> minPath(City endCity)
        {
            List<City> citiesPath = new List<City>();
            City tempCity = new City();
            tempCity = endCity;

            while(tempCity != this.firstCity)
            {
                citiesPath.Add(tempCity);
                tempCity = tempCity.prevCity;

            }
            return citiesPath;
        }
    }
}
