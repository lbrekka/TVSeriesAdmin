<template>
  <div id="app">
    <Navbar/>
    <b-container fluid>
  <!-- Content here -->
        <TvShowsTable v-bind:shows="shows"/>
    </b-container>

    <!-- <b-table striped hover :shows="shows" :fields="fields"></b-table> -->

  </div>
</template>

<script>
import TvShowsTable from './components/TvShowsTable.vue'
import Navbar from './components/Navbar.vue'

import axios from 'axios';

export default {
  name: 'App',
  components: {
    TvShowsTable,
    Navbar
  },
  data() {
      return {
          shows: []
      }
  },
  created() {
    axios.get('/api/TvShows')
      .then(res => this.shows = res.data)
      .catch(err => console.log(err));
  },
  fields: []

}
// fields = ['id', 'name', 'type'];

</script>

<style>
/* #app {
  font-family: Avenir, Helvetica, Arial, sans-serif;
  -webkit-font-smoothing: antialiased;
  -moz-osx-font-smoothing: grayscale;
  text-align: center;
  color: #2c3e50;
  margin-top: 60px;
} */
</style>
