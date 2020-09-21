<template>
    <div>
        <!-- <b-table striped hover class="table-hover" v-if="shows">
            <thead>
                <tr>
                    <th>Id</th>
                    <th>Status</th>
                    <th>Title</th>
                </tr>
            </thead>
            <tbody>
                <tr v-for="show in shows" v-bind:key="show.id">
                    <td>{{ show.id }}</td>
                    <td>{{ show.name }}</td>
                    <td>{{ show.type }}</td>
                </tr>
            </tbody>
        </b-table> -->
        <b-table striped hover :items="shows" :fields="fields"></b-table>

    </div>
    <!-- <div id="app"> -->
        <!-- <div v-for="show in shows" v-bind:key="show.id">
            <h3>{{show.name}}</h3>
        </div> -->
        <!-- <div>
            <b-table striped hover :shows="shows" :fields="fields"></b-table>
        </div> -->
    <!-- </div> -->

</template>
<script>
export default {
  name: 'Shows',
  fields: ['id', 'name', 'name'],
  props: ["shows"],
//   data() {
//       return {
//           items: ["shows"]
//       } 
//   }
}

</script>

<!-- Add "scoped" attribute to limit CSS to this component only -->
<style scoped>

</style>
