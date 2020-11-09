using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace SiAKOD_RGR_Nail
{
    class KuhnAlgorithm
    {
        public List<Vertex> vertexs;
        public List<Edge> edges;
        public List<Edge> mt = new List<Edge>();

        Panel paintbox;

        public List<Vertex> LeftVertexs = new List<Vertex>();
        public List<Vertex> RightVertexs = new List<Vertex>();

        public KuhnAlgorithm(List<Vertex> vertexs_, List<Edge> edges_, Panel paintbox_)
        {
            vertexs = vertexs_;
            edges = edges_;
            paintbox = paintbox_;
        }

        //Опредление принадложености вершины к одной из сторон двудольного графа
        public void getSideVert()
        {
            foreach(Vertex vert in vertexs)
            {
                if (vert.isLeft)
                    LeftVertexs.Add(vert);
                else
                    RightVertexs.Add(vert);
            }
        }

        //Алгоритм Куна
        bool Kuhn(Vertex vert)
        {
            if (vert.isChecked)
                return false;

            vert.isChecked = true;

            foreach (Vertex rvert in RightVertexs)
            {
                if (rvert.HasLink(vert))
                {
                    if (rvert.Link == null || Kuhn(rvert))
                    {
                        rvert.Link = vert;
                        mt.Add(vert.getLink(rvert));
                        return true;
                    }
                }
            }
            return false;
        }

        //Применение алгоритма Куна к каждой из вершин левой части графа
        public int Solve()
        {
            getSideVert();
            foreach (Vertex vert in LeftVertexs)
                Kuhn(vert);

            //Визуализация узлов парасочетания
            foreach (Edge edg in mt)
            {
                edg.color = Color.Yellow;
                paintbox.Refresh();
                System.Threading.Thread.Sleep(500);
            }
                
            return mt.Count();
        }


    }

    
}
