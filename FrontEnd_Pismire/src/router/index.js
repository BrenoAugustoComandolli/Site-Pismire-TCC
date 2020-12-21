import Vue from 'vue'
import VueRouter from 'vue-router'
import Home from '../views/Home.vue'
import FaleConosco from '../views/FaleConosco.vue'
import Cadastro from '../views/Cadastro.vue'
import Download from '../views/Download.vue'
import Ajuda from '../views/Ajuda.vue'
import QuemSomos from '../views/QuemSomos.vue'
import Trabalhador from '../views/Trabalhador.vue'
import Empresa from '../views/Empresa.vue'

Vue.use(VueRouter)

  const routes = [
  {
    path: '/',
    name: 'Home',
    component: Home
  },
  {
    path: '/faleconosco',
    name: 'FaleConosco',
    component: FaleConosco
  },
  {
    path: '/cadastro',
    name: 'Cadastro',
    component: Cadastro,
  },
  {
    path: '/download',
    name: 'Download',
    component: Download
  },
  {
    path: '/ajuda',
    name: 'Ajuda',
    component: Ajuda
  },
  {
    path: '/quemsomos',
    name: 'QuemSomos',
    component: QuemSomos
  },
  {
    path: '/trabalhador',
    name: 'Trabalhador',
    component: Trabalhador
  },
  {
    path: '/empresa',
    name: 'Empresa',
    component: Empresa
  }
  
]

const router = new VueRouter({
  mode: 'history',
  base: process.env.BASE_URL,
  routes
})

export default router
